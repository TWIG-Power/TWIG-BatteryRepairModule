using System.Data.Common;
using BatteryRepairModule.Forms.Add_Forms;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadAwaitingQualityStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\", serial_number FROM public.ticket WHERE \"status_fk\" = 5", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.activeTwigCaseNumbers.Clear();
                dbInformation.activeModuleSerialNumbers.Clear(); 
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        dbInformation.activeTwigCaseNumbers.Add(reader.GetInt16(0), reader.GetInt32(1));
                        dbInformation.activeModuleSerialNumbers.Add(reader.GetInt16(0), reader.GetInt32(2));
                    }
                }
            }
        }
    }

    public static void updateOemChecklist(int updatedSurroKey)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            string oemKey = dbInformation.selectedOemModelKeyPair.Keys.First();
            string? tableName = oemKey switch
            {
                "cobra" => "cobra_oem",
                "ktm" => "ktm_oem",
                "misc" => "misc_oem",
                _ => null
            };

            if (tableName != null)
            {
                using (var cmd = new NpgsqlCommand($"UPDATE public.{tableName} SET quality_checklist = @updatedSurro WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@updatedSurro", updatedSurroKey);
                    cmd.Parameters.AddWithValue("@id", dbInformation.selectedOemModelKeyPair.Values.First());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public static int updateLatestChecklistForm(byte[] fileData, string fileName)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.quality_options (checklist, file_name) VALUES (@fileData, @fileName) RETURNING id", conn))
        {
            cmd.Parameters.AddWithValue("@fileData", fileData);
            cmd.Parameters.AddWithValue("@fileName", fileName);

            conn.Open();
            var result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                throw new InvalidOperationException("No id was returned from the database.");
            }
        }
    }

    public static void getLatestChecklistVersion()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            using (var cmd = new NpgsqlCommand($@"
                    SELECT qo.file_name, qo.checklist
                    FROM public.{dbInformation.moduleTypeKeyValue.Values.First()} oem
                    JOIN public.quality_options qo ON oem.quality_checklist = qo.id
                    WHERE oem.id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", dbInformation.moduleTypeKeyValue.Keys.First());
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dbInformation.downloadedFileName = reader.GetString(0);
                        dbInformation.downloadedFileBytes = (byte[])reader["checklist"];
                    }
                }
            }
        }
    }

    public static bool uploadCompletedQualityChecklist(byte[] checklist)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO quality_recorded (ticket_fk, checklist, timestamp, staff_fk) VALUES (@ticketId, @checklist, @timestamp, @staffFk)", conn))
        {
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@checklist", checklist);
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
            cmd.Parameters.AddWithValue("@staffFk", dbInformation.selectedStaffKeyValue.Keys.First());
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

    public static void clearModuleForInvoice()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Invoice").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @status WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.ExecuteNonQuery(); 
        }
    }
}