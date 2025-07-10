using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadAwaitingInvoiceTickets()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Invoice").Key; 
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();

            using (var cmd = new NpgsqlCommand(
                @$"SELECT DISTINCT t.twig_ticket_number, t.serial_number, 
                        CASE 
                            WHEN t.cobra_fk IS NOT NULL THEN 'Cobra'
                            WHEN t.ktm_fk IS NOT NULL THEN 'KTM'
                            WHEN t.misc_fk IS NOT NULL THEN 'Misc'
                            ELSE 'Unknown'
                        END AS oem,
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
                dbInformation.awaitingInvoiceModuleList.Clear();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ticketId = reader.GetInt16(0);
                        int serialNumber = reader.GetInt32(1);
                        string oem = reader.GetString(2);
                        string stateOfHealth = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);

                        Module module = new Module(ticketId, serialNumber, oem);
                        module.stateOfHealth = stateOfHealth;
                        dbInformation.awaitingInvoiceModuleList.Add(module);
                    }
                }
            }
        }
    }

    public static void loadAwaitingShippingTickets()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Shipping").Key; 
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();

            using (var cmd = new NpgsqlCommand(
                @$"SELECT DISTINCT t.twig_ticket_number, t.serial_number, 
                        CASE 
                            WHEN t.cobra_fk IS NOT NULL THEN 'Cobra'
                            WHEN t.ktm_fk IS NOT NULL THEN 'KTM'
                            WHEN t.misc_fk IS NOT NULL THEN 'Misc'
                            ELSE 'Unknown'
                        END AS oem,
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
                dbInformation.awaitingShippingModuleList.Clear();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ticketId = reader.GetInt16(0);
                        int serialNumber = reader.GetInt32(1);
                        string oem = reader.GetString(2);
                        string stateOfHealth = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);

                        Module module = new Module(ticketId, serialNumber, oem);
                        module.stateOfHealth = stateOfHealth;
                        dbInformation.awaitingShippingModuleList.Add(module);
                    }
                }
            }
        }
    }

    public static void clearModuleForShipping(Module module)
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Shipping").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand($"UPDATE public.ticket SET status_fk = {status}, status_timestamp = @timestamp WHERE twig_ticket_number = {module.ticketId}", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now); 
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    
    public static void clearModuleAsShippedOrClosed(Module module)
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Shipped / Closed").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand($"UPDATE public.ticket SET status_fk = {status}, status_timestamp = @timestamp WHERE twig_ticket_number = {module.ticketId}", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now); 
            cmd.ExecuteNonQuery();
            conn.Close(); 
        }
    }
}