using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void getRepairOptions()
    {
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
    
    public static void insertRepairRepairForm()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.authorized_repairs (ticket_fk, repair_fk, staff_authorized_fk, status_fk) VALUES (@ticketId, @repairId, @authoStaff, 1)", conn))
        {
            conn.Open();
            foreach (var repair in dbInformation.newRepairActionInRepairFormKeyValue)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
                cmd.Parameters.AddWithValue("@repairId", repair.Key);
                cmd.Parameters.AddWithValue("@authoStaff", dbInformation.selectedStaffKeyValue.Keys.First());
                cmd.ExecuteNonQuery();
            }
        }
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = 3 WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }
}