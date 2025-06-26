using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void getRepairOptions() {
        dbInformation.repairActionOptions.Clear(); 
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"description\" FROM public.repair_options", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                        dbInformation.repairActionOptions.Add(reader.GetInt16(0), reader.GetString(1));
                }
            }
        }
    }
}