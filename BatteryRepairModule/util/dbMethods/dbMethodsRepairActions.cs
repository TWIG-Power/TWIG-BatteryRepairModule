using System.Runtime.InteropServices;
using Npgsql;
using NpgsqlTypes; 

namespace BatteryRepairModule;

public static partial class dbMethods
{
    public static void loadAwaitingRepairActionsStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT \"id\", \"twig_ticket_number\" FROM public.ticket WHERE \"status_fk\" = 3", conn))
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

    public static void loadRepairActionKeyValueStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            @"SELECT ar.id, 
                    r.description AS repair_description, 
                    s.status AS repair_status
                FROM public.authorized_repairs ar
                INNER JOIN public.repair_options r ON ar.repair_fk = r.id
                INNER JOIN public.repair_action_status s ON ar.status_fk = s.id
                WHERE ar.ticket_fk = @ticket_fk", conn))
        {
            cmd.Parameters.AddWithValue("@ticket_fk", dbInformation.selectedTwigTicketKeyPair.Keys.First());

            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.clearedRepairsKeyValPair.Clear();
                dbInformation.clearedRepairsKeyStatusPair.Clear();
                dbInformation.clearedRepairsValueStatusPair.Clear();

                while (reader.Read())
                {
                    dbInformation.clearedRepairsKeyValPair.Add(reader.GetInt16(0), reader.GetString(1));
                    dbInformation.clearedRepairsKeyStatusPair.Add(reader.GetInt16(0), reader.GetString(2));
                    dbInformation.clearedRepairsValueStatusPair.Add(reader.GetString(1), reader.GetString(2));
                }
            }
        }
    }

    public static void loadReportedIssuesAndStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            @"SELECT rcr.report_type_fk, 
                    rt.description AS report_type_description, 
                    rs.status AS report_status
                FROM public.registered_customer_report rcr
                INNER JOIN public.report_types rt ON rcr.report_type_fk = rt.id
                INNER JOIN public.report_status rs ON rcr.report_status_fk = rs.id
                WHERE rcr.ticket_fk = @ticket_fk", conn))
        {
            cmd.Parameters.AddWithValue("@ticket_fk", dbInformation.selectedTwigTicketKeyPair.Keys.First());

            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                dbInformation.reportedIssueKeyValue.Clear();
                dbInformation.reportedIssueKeyStatus.Clear();
                dbInformation.reportedIssuesValueStatus.Clear();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2))
                    {
                        dbInformation.reportedIssueKeyValue.Add(reader.GetInt16(0), reader.GetString(1));
                        dbInformation.reportedIssueKeyStatus.Add(reader.GetInt16(0), reader.GetString(2));
                        dbInformation.reportedIssuesValueStatus.Add(reader.GetString(1), reader.GetString(2));
                    }
                }
            }
        }
    }

    public static void loadIssueStatusOptions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"status\" FROM public.report_status", conn))
        {
            dbInformation.issueStatusOptionsKeyValue.Clear();
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.issueStatusOptionsKeyValue.Add(reader.GetInt16(0), reader.GetString(1));
                }
            }
        }
    }

    public static void loadRepairStatusOptions()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("SELECT DISTINCT \"id\", \"status\" from public.repair_action_status", conn))
        {
            dbInformation.repairStatusOptionKeyValue.Clear();
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dbInformation.repairStatusOptionKeyValue.Add(reader.GetInt16(0), reader.GetString(1));
                }
            }
        }
    }

    public static void updateIssueStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.registered_customer_report SET report_status_fk = @newStatusId WHERE ticket_fk = @ticketId AND report_type_fk = @reportTypeFk", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@newStatusId", dbInformation.tempUpdateIssueStatusHolder.Keys.First());
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@reportTypeFk", dbInformation.tempUpdateIssueIssueHolder.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }

    public static void updateRepairStatus()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.authorized_repairs SET staff_repaired_fk = @staffRepaired, timestamp = @timestamp, status_fk = @status WHERE ticket_fk = @ticketId AND id = @authorizedId", conn))
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

    public static void updateRepairNotes()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.authorized_repairs SET note = @note WHERE ticket_fk = @ticketId AND id = @authorizedId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@note", dbInformation.repairNotes);
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@authorizedId", dbInformation.tempUpdateNotesRepairHolder.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }

    public static void getRepairNotes()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            "SELECT note FROM public.authorized_repairs WHERE ticket_fk = @ticketId AND id = @authorizedId", conn))
        {
            if (!dbInformation.selectedTwigTicketKeyPair.Keys.Any() || !dbInformation.tempUpdateNotesRepairHolder.Keys.Any())
            {
                throw new InvalidOperationException("Required keys are missing in the dictionaries.");
            }

            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.Parameters.AddWithValue("@authorizedId", dbInformation.tempUpdateNotesRepairHolder.Keys.First());

            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbInformation.repairNotes = !reader.IsDBNull(0) ? reader.GetString(0) : string.Empty;
                    }
                }
                else
                {
                    dbInformation.repairNotes = string.Empty;
                }
            }
        }
    }

    public static void clearModuleForTesting()
    {
        int status = dbInformation.ticketStatusOptions.FirstOrDefault(kvp => kvp.Value == "Awaiting Testing").Key;
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand("UPDATE public.ticket SET status_fk = @statusFk WHERE id = @ticketId", conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@statusFk", status);
            cmd.Parameters.AddWithValue("@ticketId", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            cmd.ExecuteNonQuery();
        }
    }

    public static void getDoesRepairHaveNote()
    {
        using (var conn = new NpgsqlConnection(dbConnection.connectionPath))
        using (var cmd = new NpgsqlCommand(
            @"SELECT r.description, ar.note 
                FROM public.authorized_repairs ar
                INNER JOIN public.repair_options r ON ar.repair_fk = r.id
                WHERE ar.ticket_fk = @ticketFk", conn))
        {
            dbInformation.repairHasNoteStringBool.Clear();
            conn.Open();
            cmd.Parameters.AddWithValue("@ticketFk", dbInformation.selectedTwigTicketKeyPair.Keys.First());
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bool hasNote = !reader.IsDBNull(1) && !string.IsNullOrWhiteSpace(reader.GetString(1));
                    dbInformation.repairHasNoteStringBool.Add(reader.GetString(0), hasNote);
                }
            }
        }
    }
}