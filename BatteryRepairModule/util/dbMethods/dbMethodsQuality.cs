using System.Data.Common;
using BatteryRepairModule.Forms.Add_Forms;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadModulesAwaitingQuality()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Quality").Key; 
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();

            using (var cmd = new NpgsqlCommand(
                @$"SELECT DISTINCT t.id, t.twig_ticket_number, t.serial_number, 
                        CASE 
                            WHEN t.cobra_fk IS NOT NULL THEN 'Cobra'
                            WHEN t.ktm_fk IS NOT NULL THEN 'KTM'
                            WHEN t.misc_fk IS NOT NULL THEN 'Misc'
                            ELSE 'Unknown'
                        END AS oem,
                        CASE 
                            WHEN t.cobra_fk IS NOT NULL THEN (SELECT module_type FROM public.cobra_oem WHERE cobra_oem.id = t.cobra_fk)
                            WHEN t.ktm_fk IS NOT NULL THEN (SELECT module_type FROM public.ktm_oem WHERE ktm_oem.id = t.ktm_fk)
                            WHEN t.misc_fk IS NOT NULL THEN (SELECT module_type FROM public.misc_oem WHERE misc_oem.id = t.misc_fk)
                            ELSE 'Unknown'
                        END AS module_type,
                        (
                            SELECT ta2.state_of_health
                            FROM public.testing_added ta2
                            WHERE ta2.ticket_fk = t.id
                            ORDER BY ta2.id ASC
                            LIMIT 1
                        ) AS state_of_health
                FROM public.ticket t
                WHERE t.status_fk = {status}", conn))
            {
                dbInformation.activeModules.Clear();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ticketSurroKey = reader.GetInt32(0);
                        int twigTicketNumber = reader.GetInt32(1);
                        int serialNumber = reader.GetInt32(2);
                        string oem = reader.GetString(3);
                        string moduleType = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);
                        string stateOfHealth = reader.IsDBNull(5) ? "Unknown" : reader.GetString(5);

                        Module module = new Module(ticketSurroKey, twigTicketNumber, serialNumber, oem, moduleType, stateOfHealth);
                        dbInformation.activeModules.Add(module);
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
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @status, status_timestamp = @timestamp WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now); 

            cmd.ExecuteNonQuery(); 
        }
    }
}