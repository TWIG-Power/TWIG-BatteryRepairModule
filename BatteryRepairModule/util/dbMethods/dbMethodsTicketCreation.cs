using System.Data.Common;
using Npgsql;
using NpgsqlTypes;

namespace BatteryRepairModule;

public static partial class dbMethods
{
    #region LOAD QUERIES
    public static void loadStaffTicketCreation()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"name\" FROM public.staff WHERE open_tickets = true ORDER by name ASC", conn))
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
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\" FROM public.ticket WHERE \"twig_ticket_number\" = @ticketNum", conn))
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
    public static bool createDatabaseTicket(int ticketNumber, Dictionary<int, string> staff)
    {
        int initialStatus = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Service Inspection").Key;

        if (dbInformation.selectedModuleType.Keys.First() == 0)
        {
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk, cobra_fk, serial_number, status_timestamp) VALUES (@ticketNum, @vehicleVin, @staffStarting, @status, @cobra_fk, @serialNumber, @timestamp)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ticketNum", ticketNumber);
                cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@staffStarting", staff.Keys.First());
                cmd.Parameters.AddWithValue("@status", initialStatus);
                cmd.Parameters.AddWithValue("@cobra_fk", dbInformation.selectedModuleType[0].Keys.First());
                cmd.Parameters.AddWithValue("@serialNumber", dbInformation.batterySerialNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        else if (dbInformation.selectedModuleType.Keys.First() == 1)
        {
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk, ktm_fk, serial_number, status_timestamp) VALUES (@ticketNum, @vehicleVin, @staffStarting, @status, @ktm_fk, @serialNumber, @timestamp)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ticketNum", ticketNumber);
                cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@staffStarting", dbInformation.selectedStaffKeyValue.Keys.First());
                cmd.Parameters.AddWithValue("@status", initialStatus);
                cmd.Parameters.AddWithValue("@ktm_fk", dbInformation.moduleTypesByOEM[1].Keys.First());
                cmd.Parameters.AddWithValue("@serialNumber", dbInformation.batterySerialNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        else if (dbInformation.selectedModuleType.Keys.First() == 2)
        {
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand("INSERT INTO public.ticket (twig_ticket_number, vehicle_vin_number, staff_starting_report_fk, status_fk, misc_fk, serial_number, status_timestamp) VALUES (@ticketNum, @vehicleVin, @staffStarting, @status, @misc_fk, @serialNumber, @timestamp)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ticketNum", ticketNumber);
                cmd.Parameters.AddWithValue("@vehicleVin", dbInformation.vehicleVINNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@staffStarting", dbInformation.selectedStaffKeyValue.Keys.First());
                cmd.Parameters.AddWithValue("@status", initialStatus);
                cmd.Parameters.AddWithValue("@misc_fk", dbInformation.moduleTypesByOEM[2].Keys.First());
                cmd.Parameters.AddWithValue("@serialNumber", dbInformation.batterySerialNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        else
        {
            int rowsAffected = 0;
            return rowsAffected > 0;
        }
    }


    public static bool insertInitialAssessment()
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
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;

        }
    }

    public static bool insertCustomerReport()
    {
        if (!dbInformation.moduleReportedErrorsKeyPair.Any()) return false;

        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();
            int ticketSurrogateKey = getTicketSurrogateKey();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.registered_customer_report (report_type_fk, ticket_fk, report_status_fk) VALUES (@reportTypeFk, @ticketFk, 1)", conn))
            {
                bool anyInserted = false;
                foreach (var reportedError in dbInformation.moduleReportedErrorsKeyPair)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@reportTypeFk", reportedError.Key);
                    cmd.Parameters.AddWithValue("@ticketFk", ticketSurrogateKey);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        anyInserted = true;
                    }
                }
                return anyInserted;
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

    public static void getTicketStatusOptions()
    {
        try
        {
            dbInformation.ticketStatusOptions.Clear();
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand("SELECT id, status FROM public.ticket_status", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dbInformation.ticketStatusOptions.Add(reader.GetInt16(0), reader.GetString(1));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString()); 
        }
    }


    public static bool checkIfSerialNumberHasActiveTicket(int? serialNumber, Dictionary<int, string> dictSelectedMod)
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Shipped / Closed").Key;
        var parts = dictSelectedMod.Values.First().Split(' ');
        string firstPart = parts.Length > 0 ? parts[0] : "";

        string oemColumn = firstPart switch
        {
            "COBRA" => "cobra_fk",
            "KTM" => "ktm_fk",
            "MISC" => "misc_fk",
            _ => null
        };

        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            $"SELECT COUNT(*) FROM public.ticket WHERE serial_number = @serialNumber AND {oemColumn} = @moduleType AND status_fk != @status", conn))
        {
            cmd.Parameters.AddWithValue("@serialNumber", serialNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@moduleType", dictSelectedMod.Keys.First());
            cmd.Parameters.AddWithValue("@status", status);
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int count = reader.GetInt16(0);
                    if (count > 0)
                    {
                        MessageBox.Show("Serial number has an active ticket.", "Active Ticket Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                        return true;
                }
            }
            MessageBox.Show("Check could not be executed. Serial number has an active ticket.", "Check Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool checkIfSerialNumberHasBeenServiced(int? serialNumber, Dictionary<int, string> dictSelectedMod)
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Shipped / Closed").Key;
        var parts = dictSelectedMod.Values.First().Split(' ');
        string firstPart = parts.Length > 0 ? parts[0] : "";

        string oemColumn = firstPart switch
        {
            "COBRA" => "cobra_fk",
            "KTM" => "ktm_fk",
            "MISC" => "misc_fk",
            _ => null
        };

        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            $"SELECT COUNT(*) FROM public.ticket WHERE serial_number = @serialNumber AND {oemColumn} = @moduleType AND status_fk = @status", conn))
        {
            cmd.Parameters.AddWithValue("@serialNumber", serialNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@moduleType", dictSelectedMod.Keys.First());
            cmd.Parameters.AddWithValue("@status", status);
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int count = reader.GetInt16(0);
                    if (count > 0)
                    {
                        MessageBox.Show("Serial Number has been serviced before. Please check status review for previous logs.", "Serial Number History Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    else
                        return true;
                }
            }
            MessageBox.Show("Check could not be executed. Serial number has an active ticket.", "Check Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
