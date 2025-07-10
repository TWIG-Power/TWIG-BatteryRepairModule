using Npgsql;
using NpgsqlTypes;

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void recycleStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = 0, status_timestamp = @timestamp WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now); 

            cmd.ExecuteNonQuery();
        }
    }
}