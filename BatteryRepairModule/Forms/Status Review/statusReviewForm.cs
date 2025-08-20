using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text; 

namespace BatteryRepairModule.Forms.Status_Review
{
    public partial class statusReviewForm : Form
    {
        private string[] oems = {
            "Cobra",
            "KTM",
            "Misc",
            "All"
        };
        public statusReviewForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            dbMethods.loadAllTickets();

            dbMethods.getTicketStatusOptions();

            foreach (Module module in dbInformation.activeModules)
            {
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - ({module.SerialNumber}) - {module.stateOfHealth} - {module.ticketStatus}");
            }

            moduleOemFilterDropDown.Items.AddRange(oems);
            partNumberModelFilter.Enabled = false;

            partNumberModelFilter.Items.AddRange(dbInformation.ticketStatusOptions.Select(s => s.Value.ToString()).ToArray()); 
        }

        private void viewDetailedReport_Click(object sender, EventArgs e)
        {
            if (queryListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket.", "No Ticket Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedText = queryListBox.SelectedItem.ToString();
            string[] parts = selectedText.Split('-');
            string pulledStatus = parts.Length > 4 ? parts[4].Trim() : string.Empty;

            int selectedTicket = Int32.Parse(selectedText.Split('[')[1].Split(']')[0]);
            int selectedModule = dbInformation.activeModules.FirstOrDefault(m => m.ticketId == selectedTicket).ticketSurrogateKey;

            switch (pulledStatus)
            {
                case "Awaiting Service Inspection":
                    List<CustomerReport> list = dbMethods.GetCustomerReports(selectedModule);
                    string listOfRepots = string.Empty;
                    foreach (CustomerReport report in list) {
                        listOfRepots += $"{report.description} \n";
                    }
                    MessageBox.Show($"Customer Reports: \n" + listOfRepots, "Customer Report List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto awaitingServiceInspectionSkip;
            }

            Module result = dbMethods.getAllTicketInformation(selectedModule);

            HTMLReportGenerator.generateModuleReport(result);
            pullDiagnosticFile(result);
            pullQualityChecklist(result);

        awaitingServiceInspectionSkip:
            Thread.Sleep(1); 
        }

        private void moduleOemFilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            partNumberModelFilter.Enabled = true;

            var filteredList = dbInformation.activeModules
                .Where(module => moduleOemFilterDropDown.SelectedItem.ToString() == "All" || module.Oem == moduleOemFilterDropDown.SelectedItem.ToString())
                .OrderBy(module => module.model)
                .ThenBy(module => module.SerialNumber)
                .ThenBy(module => module.ticketStatus)
                .ToList();

            queryListBox.Items.Clear();

            foreach (var module in filteredList)
            {
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - ({module.SerialNumber}) - {module.stateOfHealth} - {module.ticketStatus}");
            }
        }

        private void partNumberModelFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredList = dbInformation.activeModules
                .Where(module => moduleOemFilterDropDown.SelectedItem.ToString() == "All" || module.Oem == moduleOemFilterDropDown.SelectedItem.ToString())
                .Where(module => partNumberModelFilter.SelectedItem.ToString() == "All" || module.ticketStatus == partNumberModelFilter.SelectedItem.ToString())
                .OrderBy(module => module.model)
                .ThenBy(module => module.SerialNumber)
                .ToList();

            queryListBox.Items.Clear();

            foreach (var module in filteredList)
            {
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - ({module.SerialNumber}) - {module.stateOfHealth} - {module.ticketStatus}");
            }
        }

        private void pullDiagnosticFile(Module result)
        {
            byte[] file = dbMethods.pullDiagnosticFile(result.ticketSurrogateKey);
            if (file != null && file.Length > 0)
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Battery-Repair-Module", "Status-Review-Reports", $"Service_Report_{result.ticketId}");

                string fileName = $"Diagnostic_Report_{result.ticketId}.html";
                string filePath = Path.Combine(folderPath, fileName);

                File.WriteAllBytes(filePath, file);
                MessageBox.Show("Diagnostic report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No diagnostic file was found for the selected ticket.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pullQualityChecklist(Module result)
        {
            byte[] file = dbMethods.pullQualityChecklist(result);
            if (file != null && file.Length > 0)
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Battery-Repair-Module", "Status-Review-Reports", $"Service_Report_{result.ticketId}");

                string fileName = $"Quality_Checklist_{result.ticketId}.pdf";
                string filePath = Path.Combine(folderPath, fileName);

                File.WriteAllBytes(filePath, file);
            }
            else
            {
                MessageBox.Show("Error getting quality checklist. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}