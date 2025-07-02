using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{

    public static void loadAwaitingTestingTickets()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\" FROM public.ticket WHERE \"status_fk\" = 4", conn))
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

    public static void getTestingOptions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"test\" FROM public.testing_options ORDER BY \"id\" ASC", conn))
        {
            dbInformation.testingOptionsKeyValue.Clear();
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.testingOptionsKeyValue.Add(reader.GetInt16(0), reader.GetString(1));
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
                dbInformation.addedTestValueStatus.Clear();
                while (reader.Read())
                {
                    dbInformation.addedTestsKeyValue.Add(reader.GetInt32(0), reader.GetString(1));
                    dbInformation.addedTestsKeyStatus.Add(reader.GetInt16(0), reader.GetString(2));
                    dbInformation.addedTestValueStatus.Add(reader.GetString(1), reader.GetString(2));
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
            cmd.Parameters.AddWithValue("@staffFk", dbInformation.selectedStaffKeyValue.Keys.First());
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
        using (var cmd = new NpgsqlCommand("UPDATE public.testing_added SET note = @note WHERE ticket_fk = @ticketId AND test_fk = @testId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@note", dbInformation.testNotes);
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@testId", dbInformation.tempTestNoteHolder.Keys.First());
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

    public static void updateTestStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.testing_added SET staff_fk = @staffFk, timestamp = @timestamp, status_fk = @status WHERE ticket_fk = @ticketId AND test_fk = @testFk", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@staffRepaired", dbInformation.selectedStaffKeyValue.Keys.First());
            cmd.Parameters.AddWithValue("@timestamp", System.DateTime.Now);
            cmd.Parameters.AddWithValue("@status", dbInformation.tempUpdateRepairStatusHolder.Keys.First());
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@authorizedId", dbInformation.tempUpdateRepairRepairHolder.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }
}