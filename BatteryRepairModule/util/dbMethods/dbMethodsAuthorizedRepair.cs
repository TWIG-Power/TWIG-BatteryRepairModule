using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadAwaitingAuthorizeRepairTickets()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\", serial_number FROM public.ticket WHERE \"status_fk\" = 2", conn))
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
    public static void insertAuthorizedRepairs()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.authorized_repairs (ticket_fk, repair_fk, staff_authorized_fk, status_fk) VALUES (@ticketId, @repairId, @authoStaff, 1)", conn))
        {
            conn.Open();
            foreach (var repair in dbInformation.clearedRepairsKeyValPair)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
                cmd.Parameters.AddWithValue("@repairId", repair.Key);
                cmd.Parameters.AddWithValue("@authoStaff", dbInformation.selectedStaffKeyValue.Keys.First());
                cmd.ExecuteNonQuery();
            }
        }
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Repair Actions").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @status WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@status", status); 
            cmd.ExecuteNonQuery();
        }
    }
}