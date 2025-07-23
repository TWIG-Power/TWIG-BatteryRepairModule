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
        private string[] oems = { "Cobra", "KTM", "Misc", "All" };
        public statusReviewForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            dbMethods.loadAllTickets();

            foreach (Module module in dbInformation.activeModules)
            {
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - ({module.SerialNumber}) - {module.stateOfHealth} - {module.ticketStatus}");
            }

            moduleOemFilterDropDown.Items.AddRange(oems);
            partNumberModelFilter.Enabled = false;
        }

        private void viewDetailedReport_Click(object sender, EventArgs e)
        {
            if (queryListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket.", "No Ticket Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTicket = Int32.Parse(queryListBox.SelectedItem.ToString().Split('[')[1].Split(']')[0]);
            int selectedModule = dbInformation.activeModules.FirstOrDefault(m => m.ticketId == selectedTicket).ticketSurrogateKey;

            Module result = dbMethods.getAllTicketInformation(selectedModule);

            HTMLReportGenerator.generateModuleReport(result);
            pullDiagnosticFile(result);
            pullQualityChecklist(result); 

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