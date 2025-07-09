using BatteryRepairModule.Forms.Service_Inspection_Forms;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    #region LOAD METHODS
    public static void loadAwaitingServiceInspectionTickets()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\", serial_number FROM public.ticket WHERE \"status_fk\" = 1", conn))
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
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @status WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@status", status);
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