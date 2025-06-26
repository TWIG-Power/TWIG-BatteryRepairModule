using BatteryRepairModule.Forms.Service_Inspection_Forms;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    #region LOAD METHODS
    public static void loadActiveTwigTickets()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\" FROM public.ticket WHERE \"status_fk\" = 1", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.activeTwigCaseNumbers.Clear();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        dbInformation.activeTwigCaseNumbers.Add(reader.GetInt16(0), reader.GetInt32(1));
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
            cmd.Parameters.AddWithValue("@ticketFk", serviceInspectionForm1.tempSelectedTwigTicketKeyPair.Keys.First());

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

    #endregion

    #region Insert Methods 

    public static void insertSuggestedRepairs()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.proposed_repairs (repair_id_fk, ticket_fk) VALUES (@repairId, @ticketId)", conn))
        {
            conn.Open();
            int ticketSurroKey = dbMethods.getTicketSurrogateKey();
            
            foreach (var repair in dbInformation.proposedRepairsList)
            {
                cmd.Parameters.Clear(); 
                cmd.Parameters.AddWithValue("@repairId", repair.Key);
                cmd.Parameters.AddWithValue("@ticketId", ticketSurroKey);
                cmd.ExecuteNonQuery(); 
            }
        }
    }

    #endregion
}