using System.Data.Common;
using Npgsql;
using NpgsqlTypes;

namespace BatteryRepairModule;

public static partial class dbMethods
{
    #region LOAD QUERIES
    private static void AddOptionsFromReader(NpgsqlDataReader reader, List<string> optionsList)
    {
        var tempList = new List<string>();
        while (reader.Read() && !reader.IsDBNull(0))
        {
            tempList.Add(reader.GetString(0));
        }
        optionsList.Clear();
        optionsList.AddRange(tempList);
    }
    public static void loadStaffNames()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"name\" FROM public.staff", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                AddOptionsFromReader(reader, dbInformation.staffOptions);
            }
        }
        dbInformation.staffOptions.Sort();
    }

    public static void loadreportTypeOptions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"description\" FROM public.report_types ORDER BY id ASC", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.reportTypeKeyPair.Clear();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                        dbInformation.reportTypeKeyPair.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
            }
        }
    }

    public static int getTicketSurrogateKey()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\" FROM public.ticket WHERE \"twig_ticket_number\" = @ticketNum ORDER BY id ASC" , conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketNum", dbInformation.selectedTwigTicketKeyPair.Values.First());
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                        return reader.GetInt32(0);
                }
            }
        }
        return 0;
    }

    public static int getStaffSurrogateKey(string staff)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\" FROM public.staff WHERE \"name\" = @name", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@name", staff);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                        return reader.GetInt16(0);
                }
            }
        }
        return 0;
    }

    public static int getLastTwigTicketNumber()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"twig_ticket_number\" FROM public.ticket ORDER BY \"id\" DESC LIMIT 1", conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                        return reader.GetInt32(0);
                }
            }
        }
        return 0;
    }

    #endregion

    #region INSERT QUERIES
    public static void createDatabaseTicket(string staff)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk) VALUES (@ticketNum, @vehicleVin, @staffStarting, 1)", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketNum", dbInformation.TWIGCaseNumber);
            cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber);
            cmd.Parameters.AddWithValue("@staffStarting", getStaffSurrogateKey(staff));
            cmd.ExecuteNonQuery();
        }
    }


    public static void insertInitialAssessment()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.initial_assessment (report_fk, battery_leads_protected, cable_damage, charge_port, comm_port, evidence_of_tamp, gove_vent, housing_dents, housing_scrapes, missing_wires, screws_missing, verify_shipping) VALUES (@reportFk, @battLeads, @cableDamage, @chargePort, @commPort, @evidenceTamp, @goveVent, @housingDents, @housingScrapes, @missingWires, @screwsMissing, @verifyShipping)", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@reportFk", dbMethods.getTicketSurrogateKey());
            cmd.Parameters.AddWithValue("@battLeads", dbInformation.batteryLeadsProtected ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@cableDamage", dbInformation.checkCableDamage ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@chargePort", dbInformation.checkChargePort ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@commPort", dbInformation.checkCommPort ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@evidenceTamp", dbInformation.checkEvidenceOfTamp ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@goveVent", dbInformation.checkGoveVent ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@housingDents", dbInformation.checkHousingDentsHoles ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@housingScrapes", dbInformation.checkHousingScrape ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@missingWires", dbInformation.checkMissingWires ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@screwsMissing", dbInformation.checkScrewsMissing ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@verifyShipping", dbInformation.verifyShippingChoice ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();

        }
    }

    public static void insertCustomerReport()
    {
        if (!dbInformation.moduleReportedErrorsKeyPair.Any()) return;

        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();
            int ticketSurrogateKey = getTicketSurrogateKey();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.registered_customer_report (report_type_fk, ticket_fk) VALUES (@reportTypeFk, @ticketFk)", conn))
            {
                foreach (var reportedError in dbInformation.moduleReportedErrorsKeyPair)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@reportTypeFk", reportedError.Key); // Foreign key for the reported error
                    cmd.Parameters.AddWithValue("@ticketFk", ticketSurrogateKey);   // Foreign key for the ticket
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public static bool insertNewReportOption(string newOption)
    {
        try
        {
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand("INSERT INTO public.report_types (description) VALUES (@description)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@description", newOption);
                cmd.ExecuteNonQuery();
                return true; 
            }
        }
        catch (Exception ex)
        {
            return false; 
        }
    }
    #endregion
}
