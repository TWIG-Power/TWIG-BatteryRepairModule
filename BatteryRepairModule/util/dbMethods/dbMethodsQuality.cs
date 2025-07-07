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
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\" FROM public.ticket WHERE \"status_fk\" = 5", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.activeTwigCaseNumbers.Clear();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        dbInformation.activeTwigCaseNumbers.Add(reader.GetInt16(0), reader.GetInt32(1));
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

    public static int updateLatestChecklistForm(byte[] fileData) {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.quality_options (checklist) VALUES (@fileData) RETURNING id", conn))
        {
            cmd.Parameters.AddWithValue("@fileData", fileData);

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

}