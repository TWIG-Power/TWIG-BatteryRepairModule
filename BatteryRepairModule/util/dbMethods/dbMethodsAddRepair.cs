using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void getRepairOptions()
    {
        dbInformation.repairActionOptions.Clear();
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"description\" FROM public.repair_options WHERE enabled = true", conn))
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

    public static void getRepairOptionsEnabledDisabled()
    {
        dbInformation.repairOptionsList.Clear();
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"description\", enabled FROM public.repair_options", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2))
                    {
                        int tempId = reader.GetInt16(0);
                        string tempDescrip = reader.GetString(1);
                        bool getEnabled = reader.GetBoolean(2);
                        dbInformation.repairOptionsList.Add(new repairOption(tempId, tempDescrip, getEnabled));
                    }
                }
            }
        }
        dbInformation.SortRepairOptionsListById(); 
    }

    public static void updateRepairEnabledDisabled(int repairId, bool updatedStatus)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand($"UPDATE public.repair_options SET enabled = {updatedStatus} WHERE id = {repairId}", conn))
        {
            conn.Open();
            cmd.ExecuteNonQuery(); 
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