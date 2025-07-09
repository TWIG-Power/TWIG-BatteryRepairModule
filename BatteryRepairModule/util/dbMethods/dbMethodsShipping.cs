using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadAwaitingInvoiceTickets()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();

            using (var cmd = new NpgsqlCommand(
                @"SELECT DISTINCT t.twig_ticket_number, t.serial_number, 
                        CASE 
                            WHEN t.cobra_fk IS NOT NULL THEN 'Cobra'
                            WHEN t.ktm_fk IS NOT NULL THEN 'KTM'
                            WHEN t.misc_fk IS NOT NULL THEN 'Misc'
                            ELSE 'Unknown'
                        END AS oem,
                        ta.state_of_health
                FROM public.ticket t
                LEFT JOIN public.testing_added ta ON t.id = ta.ticket_fk
                WHERE t.status_fk = 6", conn))
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
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();

            using (var cmd = new NpgsqlCommand(
                @"SELECT DISTINCT t.id, t.serial_number, 
                        CASE 
                            WHEN t.cobra_fk IS NOT NULL THEN 'Cobra'
                            WHEN t.ktm_fk IS NOT NULL THEN 'KTM'
                            WHEN t.misc_fk IS NOT NULL THEN 'Misc'
                            ELSE 'Unknown'
                        END AS oem,
                        ta.state_of_health
                FROM public.ticket t
                LEFT JOIN public.testing_added ta ON t.id = ta.ticket_fk
                WHERE t.status_fk = 7", conn))
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
        using (var cmd = new NpgsqlCommand($"UPDATE public.ticket SET status_fk = {status} WHERE id = {module.ticketId}", conn))
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    
    public static void clearModuleAsShippedOrClosed(Module module)
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Shipped / Closed").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand($"UPDATE public.ticket SET status_fk = {status} WHERE id = {module.ticketId}", conn))
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close(); 
        }
    }
}