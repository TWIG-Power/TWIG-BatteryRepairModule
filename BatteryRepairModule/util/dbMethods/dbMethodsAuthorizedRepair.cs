using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void insertAuthorizedRepairs(string staff)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.authorized_repairs (ticket_fk, repair_fk, staff_authorized_fk) VALUES (@ticketId, @repairId, @authoStaff)", conn))
        {
            conn.Open();
            int ticketSurroKey = dbMethods.getTicketSurrogateKey();
            int staffSurroKey = dbMethods.getStaffSurrogateKey(staff);

            foreach (var repair in dbInformation.proposedRepairsKeyPair)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ticketId", ticketSurroKey);
                cmd.Parameters.AddWithValue("@repairId", repair.Key);
                cmd.Parameters.AddWithValue("@authoStaff", staffSurroKey);
                cmd.ExecuteNonQuery();
            }
        }
    }
}