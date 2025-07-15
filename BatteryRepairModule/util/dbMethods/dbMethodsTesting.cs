using System.Diagnostics.Tracing;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{

    public static void loadModulesAwaitingTesting()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Testing").Key;
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

    public static void getTestingOptions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"test\", requires_input FROM public.testing_options ORDER BY \"id\" ASC", conn))
        {
            dbInformation.testingOptionsKeyValue.Clear();
            dbInformation.testingOptionsRequiredKeyBoolean.Clear();
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.testingOptionsKeyValue.Add(reader.GetInt16(0), reader.GetString(1));
                    dbInformation.testingOptionsRequiredKeyBoolean.Add(reader.GetInt16(0), reader.GetBoolean(2));
                }
            }
        }
    }

    public static void getAddedTestsByTwigTicket()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            @"SELECT testing_added.id AS test_id, 
                    testing_options.test AS test_description, 
                    test_status.status AS test_status
                FROM public.testing_added
                INNER JOIN public.testing_options ON public.testing_added.test_fk = public.testing_options.id
                INNER JOIN public.test_status ON public.testing_added.status_fk = public.test_status.id
                WHERE testing_added.ticket_fk = @ticketFk", conn))
        {
            cmd.Parameters.AddWithValue("@ticketFk", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            dbInformation.addedTestsKeyValue.Clear();
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.addedTestsKeyValue.Clear();
                dbInformation.addedTestsKeyStatus.Clear();
                //dbInformation.addedTestValueStatus.Clear();
                while (reader.Read())
                {
                    dbInformation.addedTestsKeyValue.Add(reader.GetInt32(0), reader.GetString(1));
                    dbInformation.addedTestsKeyStatus.Add(reader.GetInt16(0), reader.GetString(2));
                }
            }
        }
    }

    public static void insertNewTestAction()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("INSERT INTO public.testing_added (staff_fk, status_fk, test_fk, ticket_fk, timestamp) VALUES (@staffFk, @statusFk, @testFk, @ticketFk, @timestamp)", conn))
        {
            conn.Open();
            if (dbInformation.selectedStaffKeyValue.Keys.Any())
                cmd.Parameters.AddWithValue("@staffFk", dbInformation.selectedStaffKeyValue.Keys.First());
            else
                cmd.Parameters.AddWithValue("@staffFk", DBNull.Value);
            cmd.Parameters.AddWithValue("@statusFk", 1);
            cmd.Parameters.AddWithValue("@testFk", dbInformation.tempAddNewTest.Keys.First());
            cmd.Parameters.AddWithValue("@ticketFk", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@timestamp", System.DateTime.Now);
            cmd.ExecuteNonQuery();
        }
    }

    public static void updateTestNotes()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.testing_added SET note = @note WHERE ticket_fk = @ticketId AND id = @id", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@note", dbInformation.testNotes);
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@id", dbInformation.tempTestNoteHolder.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }

    public static void getTestNotes()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            "SELECT note FROM public.testing_added WHERE ticket_fk = @ticketId AND test_fk = @testFk", conn))
        {
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@testFk", dbInformation.tempTestNoteHolder.Keys.First());

            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbInformation.testNotes = !reader.IsDBNull(0) ? reader.GetString(0) : string.Empty;
                    }
                }
                else
                {
                    dbInformation.testNotes = string.Empty;
                }
            }
        }
    }

    public static void getTestStatusOptions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT id, status FROM public.test_status ORDER BY id ASC", conn))
        {
            dbInformation.testStatusOptionsKeyValue.Clear();
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.testStatusOptionsKeyValue.Add(reader.GetInt16(0), reader.GetString(1));
                }
            }
        }
    }

    public static void updateTestStatus(string stateOfHealth)
    {
        try
        {
            using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
            using (var cmd = new NpgsqlCommand("UPDATE public.testing_added SET staff_fk = @staffFk, timestamp = @timestamp, status_fk = @status, state_of_health = @soh WHERE ticket_fk = @ticketId AND id = @testId", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@staffFk", dbInformation.selectedStaffKeyValue.Keys.First());
                cmd.Parameters.AddWithValue("@timestamp", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@status", dbInformation.tempTestStatusHolder.Keys.First());
                cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
                cmd.Parameters.AddWithValue("@testId", dbInformation.tempTestTestHolder.Keys.First());
                cmd.Parameters.AddWithValue("@soh", stateOfHealth);

                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static bool returnModuleToRepairActions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @statusFk WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@statusFk", 3);
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

    public static void getModuleType()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT cobra_fk, ktm_fk, misc_fk FROM public.ticket WHERE id = @ticketId", conn))
        {
            dbInformation.moduleTypeKeyValue.Clear();
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        dbInformation.moduleTypeKeyValue[reader.GetInt16(0)] = "cobra_oem";
                    }
                    else if (!reader.IsDBNull(1))
                    {
                        dbInformation.moduleTypeKeyValue[reader.GetInt16(1)] = "ktm_oem";
                    }
                    else if (!reader.IsDBNull(2))
                    {
                        dbInformation.moduleTypeKeyValue[reader.GetInt16(2)] = "misc_oem";
                    }
                }
            }
        }
    }

    public static void getStateOfHealthRanges()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand($"SELECT race_soh_upper, race_soh_lower, track_soh_upper, track_soh_lower, play_soh_upper, play_soh_lower, module_type FROM public.{dbInformation.moduleTypeKeyValue.Values.First()} WHERE id = @type", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@type", dbInformation.moduleTypeKeyValue.Keys.First());
            dbInformation.raceGradeHighLowKeyPair.Clear();
            dbInformation.trackGradeHighLowKeyPair.Clear();
            dbInformation.playGradeHighLowKeyPair.Clear();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.raceGradeHighLowKeyPair[reader.GetInt32(0)] = reader.GetInt32(1);
                    dbInformation.trackGradeHighLowKeyPair[reader.GetInt32(2)] = reader.GetInt32(3);
                    dbInformation.playGradeHighLowKeyPair[reader.GetInt32(4)] = reader.GetInt32(5);
                    dbInformation.moduleTypeKeyValue[dbInformation.moduleTypeKeyValue.Keys.First()] = reader.GetString(6);
                }
            }
        }
    }

    public static void getDoesTestHaveNote()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT id, note FROM public.testing_added WHERE ticket_fk = @ticketFk", conn))
        {
            dbInformation.doesTestHaveNote.Clear();
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketFk", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bool hasNote = !reader.IsDBNull(1) && !string.IsNullOrWhiteSpace(reader.GetString(1));
                    dbInformation.doesTestHaveNote.Add(reader.GetInt16(0), hasNote);
                }
            }
        }
    }

    public static void insertStateOfHealth(string stateOfHealth)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE testing_added SET state_of_health = @soh WHERE id = @id", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@soh", stateOfHealth);
            cmd.Parameters.AddWithValue("@id", dbInformation.tempTestTestHolder.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }

    public static bool clearModuleForQuality()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Quality").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @status, status_timestamp = @timestamp WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

    public static byte[] pullDiagnosticFile()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT diagnostic_report FROM public.service_inspection WHERE ticket_fk = @id", conn))
        {
            cmd.Parameters.AddWithValue("@id", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        return (byte[])reader[0];
                    }
                }
                return null;
            }
        }
    }

    public static bool attachDiagnosticFile(byte[] fileData)
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE initial_assessment SET diagnostic_file = @fileData WHERE report_fk = @reportFk", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@fileData", fileData);
            cmd.Parameters.AddWithValue("@reportFk", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}