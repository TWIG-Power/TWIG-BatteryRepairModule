using System.Net.NetworkInformation;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadAllTickets()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();

            using (var cmd = new NpgsqlCommand(
                @$"SELECT DISTINCT t.id, t.twig_ticket_number, t.serial_number, t.status_fk,  
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
                FROM public.ticket t", conn))
            {
                dbInformation.activeModules.Clear();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ticketSurroKey = reader.GetInt32(0);
                        int twigTicketNumber = reader.GetInt32(1);
                        int serialNumber = reader.GetInt32(2);
                        string oem = reader.GetString(4);
                        string moduleType = reader.IsDBNull(5) ? "Unknown" : reader.GetString(5);
                        string stateOfHealth = reader.IsDBNull(6) ? "Unknown" : reader.GetString(6);
                        int status = reader.GetInt16(3);

                        string status2 = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Key == status).Value;

                        Module module = new Module(ticketSurroKey, twigTicketNumber, serialNumber, oem, moduleType, stateOfHealth, status2);
                        dbInformation.activeModules.Add(module);

                        dbInformation.activeModules = dbInformation.activeModules.OrderBy(e => e.Oem).ThenBy(e => e.SerialNumber).ToList();
                    }
                }
            }
        }
    }

    public static initialAssesment getCompletedInitialAssesment(int ticketNumber)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(
                @"SELECT si.id, si.verify_shipping, si.housing_scrapes, si.evidence_of_tamp, si.screws_missing, 
                        si.housing_dents, si.missing_wires, si.charge_port, si.cable_damage, si.gove_vent, 
                        si.comm_port, si.battery_leads_protected, s.name
                FROM public.initial_assessment si
                LEFT JOIN public.staff s ON si.staff_fk = s.id
                WHERE si.report_fk = @ticketNumber", conn))
            {
                cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string verifyShipping = reader.GetString(1);
                        bool housingScrapes = reader.GetBoolean(2);
                        bool evidenceOfTamp = reader.GetBoolean(3);
                        bool screwsMissing = reader.GetBoolean(4);
                        bool housingDents = reader.GetBoolean(5);
                        bool missingWires = reader.GetBoolean(6);
                        bool chargePort = reader.GetBoolean(7);
                        bool cableDamage = reader.GetBoolean(8);
                        bool goveVent = reader.GetBoolean(9);
                        bool commPort = reader.GetBoolean(10);
                        bool batteryLeadsProtected = reader.GetBoolean(11);
                        string staff = reader.IsDBNull(12) ? "Unknown" : reader.GetString(12);

                        initialAssesment initialAssesment = new initialAssesment(id, verifyShipping, housingScrapes, evidenceOfTamp, screwsMissing, housingDents, missingWires, chargePort, cableDamage, goveVent, commPort, batteryLeadsProtected, staff);
                        return initialAssesment;
                    }
                }
            }
        }
        return null;
    }

    public static serviceInspection getCompletedServiceInspection(int ticketnumber)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(
                @"SELECT si.id, si.cleaning_procedures, si.diagnostic_tool_plugged, s.name
                FROM public.service_inspection si
                LEFT JOIN public.staff s ON si.staff_fk = s.id
                WHERE si.ticket_fk = @ticketNumber", conn))
            {
                cmd.Parameters.AddWithValue("@ticketNumber", ticketnumber);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        bool cleaningProcedures = reader.GetBoolean(1);
                        bool diagnosticToolPlugged = reader.GetBoolean(2);
                        string staff = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);

                        serviceInspection inspection = new serviceInspection(id, staff, cleaningProcedures, diagnosticToolPlugged);
                        return inspection;
                    }
                }
            }
        }
        return null;
    }

    public static List<RepairAction> getCompletedRepairActions(int ticketnumber)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            List<RepairAction> repairActionList = new List<RepairAction>();
            conn.Open();
            using (var cmd = new NpgsqlCommand(
                @"SELECT rp.id, rp.note, s.name, r.Description, ras.status
                FROM public.authorized_repairs rp
                LEFT JOIN public.staff s ON rp.staff_repaired_fk = s.id
                LEFT JOIN public.repair_options r ON rp.repair_fk = r.id
                LEFT JOIN public.repair_action_status ras ON rp.status_fk = ras.id
                WHERE rp.ticket_fk = @ticketNumber", conn))
            {
                cmd.Parameters.AddWithValue("@ticketNumber", ticketnumber);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string note = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string staff = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                        string optionName = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);
                        string statusName = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);
                        RepairAction repairAction = new RepairAction(id, staff, optionName, statusName, note);
                        repairActionList.Add(repairAction);
                        return repairActionList;
                    }
                }
            }
        }
        return null;
    }

    public static List<CustomerReport> GetCustomerReports(int ticketnumber)
    {
        var customerReports = new List<CustomerReport>();
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(
                @"SELECT r.description, rs.status
                FROM registered_customer_report rcr
                LEFT JOIN public.report_types r ON rcr.report_type_fk = r.id
                LEFT JOIN public.report_status rs on rcr.report_status_fk = rs.id
                WHERE rcr.ticket_fk = @ticketNumber", conn))
            {
                cmd.Parameters.AddWithValue("@ticketNumber", ticketnumber);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string reportType = reader.IsDBNull(0) ? "Unknown" : reader.GetString(0);
                        string reportStatus = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);

                        CustomerReport report = new CustomerReport(reportType, reportStatus);
                        customerReports.Add(report);
                    }
                }
            }
        }
        return customerReports;
    }

    public static List<testAction> GetCompletedTests(int ticketnumber)
    {
        var testsList = new List<testAction>();
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(
                @"SELECT t.id, s.name, tt.test, st.status, t.note, t.state_of_health
                FROM public.testing_added t
                LEFT JOIN public.staff s ON t.staff_fk = s.id
                LEFT JOIN public.testing_options tt ON t.test_fk = tt.id
                LEFT JOIN public.test_status st ON t.status_fk = st.id
                WHERE t.ticket_fk = @ticketNumber", conn))
            {
                cmd.Parameters.AddWithValue("@ticketNumber", ticketnumber);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string staff = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);
                        string testName = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                        string status = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);
                        string note = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string stateOfHealth = reader.IsDBNull(5) ? "Unknown" : reader.GetString(5);

                        testAction test = new testAction(id, staff, testName, status, note, stateOfHealth);
                        testsList.Add(test);
                    }
                }
            }
            
            return testsList;
        }
    }


}