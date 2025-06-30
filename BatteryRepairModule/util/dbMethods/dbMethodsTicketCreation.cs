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
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"name\" FROM public.staff ORDER by name ASC", conn))
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

    public static void loadAllModuleTypes()
    {
        dbInformation.moduleTypesByOEM.Clear(); 
        var tableNames = new[] { "cobra_oem", "ktm_oem", "misc_oem" };
        for (int i = 0; i < tableNames.Length; i++)
        {
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand($"SELECT \"id\", \"module_type\" FROM public.{tableNames[i]}", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {   
                        if (!dbInformation.moduleTypesByOEM.ContainsKey(i))
                        {
                            dbInformation.moduleTypesByOEM[i] = new Dictionary<int, string>();
                        }
                        dbInformation.moduleTypesByOEM[i][reader.GetInt16(0)] = reader.GetString(1);
                    }
                }
            }
        }
    }


    #endregion

    #region INSERT QUERIES
    public static void createDatabaseTicket(Dictionary<int, string> staff)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            if (dbInformation.selectedModuleType.Keys.First() == 0)
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk, cobra_fk) VALUES (@ticketNum, @vehicleVin, @staffStarting, 1, @cobra_fk)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ticketNum", dbInformation.TWIGCaseNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@staffStarting", staff.Keys.First());
                    cmd.Parameters.AddWithValue("@cobra_fk", dbInformation.moduleTypesByOEM[0].Keys.First());
                    cmd.ExecuteNonQuery();
                }
            }
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            if (dbInformation.selectedModuleType.Keys.First() == 1)
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk, ktm_fk) VALUES (@ticketNum, @vehicleVin, @staffStarting, 1, @ktm_fk)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ticketNum", dbInformation.TWIGCaseNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@staffStarting", dbInformation.selectedStaffKeyValue.Keys.First());
                    cmd.Parameters.AddWithValue("@ktm_fk", dbInformation.moduleTypesByOEM[0].Keys.First());
                    cmd.ExecuteNonQuery();
                }
            }
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            if (dbInformation.selectedModuleType.Keys.First() == 2)
            {
            using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk, misc_fk) VALUES (@ticketNum, @vehicleVin, @staffStarting, 1, @misc_fk)", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketNum", dbInformation.TWIGCaseNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@staffStarting", dbInformation.selectedStaffKeyValue.Keys.First());
            cmd.Parameters.AddWithValue("@misc_fk", dbInformation.moduleTypesByOEM[0].Keys.First()); 
            cmd.ExecuteNonQuery();
        }
        }
    }


    public static void insertInitialAssessment()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.initial_assessment (report_fk, battery_leads_protected, cable_damage, charge_port, comm_port, evidence_of_tamp, gove_vent, housing_dents, housing_scrapes, missing_wires, screws_missing, verify_shipping, staff_fk) VALUES (@reportFk, @battLeads, @cableDamage, @chargePort, @commPort, @evidenceTamp, @goveVent, @housingDents, @housingScrapes, @missingWires, @screwsMissing, @verifyShipping, @staff_fk)", conn))
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
            cmd.Parameters.AddWithValue("@staff_fk", dbInformation.selectedStaffKeyValue.Keys.First());
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
                    cmd.Parameters.AddWithValue("@reportTypeFk", reportedError.Key); 
                    cmd.Parameters.AddWithValue("@ticketFk", ticketSurrogateKey);  
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
        catch (Exception)
        {
            return false; 
        }
    }
    #endregion
}
