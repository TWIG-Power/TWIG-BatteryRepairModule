using BatteryRepairModule.Forms.Service_Inspection_Forms;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    #region LOAD METHODS

    public static void loadModulesAwaitingServiceInspection()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Service Inspection").Key; 
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

    public static void loadStaffServiceInspection()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"name\" FROM public.staff WHERE service_inspection = true ORDER by name ASC", conn))
        {
            conn.Open();
            dbInformation.staffKeyPairOptions.Clear();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.staffKeyPairOptions.Add(reader.GetInt16(0), reader.GetString(1));
                }
            }
        }
    }

    public static void LoadRegisteredCustomerReport()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(@"
            SELECT DISTINCT rt.id, rt.description 
            FROM public.registered_customer_report rcr
            INNER JOIN public.report_types rt ON rcr.report_type_fk = rt.id
            WHERE rcr.ticket_fk = @ticketFk", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketFk", dbInformation.selectedTwigTicketKeyPair.Keys.First());

            dbInformation.reportedIssuesList.Clear();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        dbInformation.reportedIssuesList[reader.GetInt32(0)] = reader.GetString(1);
                    }
                }
            }
        }
    }

    public static void LoadSuggestedRepairs()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(@"
            SELECT pr.repair_id_fk, r.description
            FROM public.proposed_repairs pr
            INNER JOIN public.repair_options r ON pr.repair_id_fk = r.id
            WHERE pr.ticket_fk = @ticketId", conn))
        {
            conn.Open();
            int ticketSurroKey = dbMethods.getTicketSurrogateKey();
            cmd.Parameters.AddWithValue("@ticketId", ticketSurroKey);

            dbInformation.proposedRepairsKeyPair.Clear();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        dbInformation.proposedRepairsKeyPair[reader.GetInt32(0)] = reader.GetString(1);
                    }
                }
            }
        }
    }

    #endregion

    #region Insert Methods 

    public static bool insertSuggestedRepairs()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.proposed_repairs (repair_id_fk, ticket_fk, staff_fk) VALUES (@repairId, @ticketId, @staff_fk)", conn))
        {
            conn.Open();
            foreach (var repair in dbInformation.proposedRepairsKeyPair)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@repairId", repair.Key);
                cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
                cmd.Parameters.AddWithValue("@staff_fk", dbInformation.selectedStaffKeyValue.Keys.First());
                int modCount = cmd.ExecuteNonQuery();
            }
        }
        
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Repair Authorization").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @status, status_timestamp = @timestamp WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now); 
            int modCount = cmd.ExecuteNonQuery();
            return modCount > 0; 
        }
    }

    public static bool createServiceInpsection(byte[] fileByte)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.service_inspection (staff_fk, cleaning_procedures, diagnostic_tool_plugged, diagnostic_report, ticket_fk) VALUES (@staff_fk, @cleaningProcedures, @diagnostic_tool_plugged, @diagnostic_report, @ticket_fk)", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@staff_fk", dbInformation.selectedStaffKeyValue.Keys.First());
            cmd.Parameters.AddWithValue("@cleaningProcedures", dbInformation.cleaningProcedures ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@diagnostic_tool_plugged", dbInformation.checkPluggedIntoDiagTool ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@diagnostic_report", fileByte ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ticket_fk", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            int modCount = cmd.ExecuteNonQuery();
            return modCount > 0; 
        }
    }

    #endregion
}