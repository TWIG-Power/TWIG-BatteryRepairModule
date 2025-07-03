using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteryRepairModule.Forms.BRM;

namespace BatteryRepairModule.Forms.Service_Inspection_Forms
{
    public partial class serviceInspectionForm1 : Form
    {
        public static int? tempTwigCaseNumber;
        public static Dictionary<int, int> tempSelectedTwigTicketKeyPair = new Dictionary<int, int>();
        public static Dictionary<int, string> tempSelectedStaffKeyPair = new Dictionary<int, string>();

        public static bool? tempCleaningProcedures;
        public static bool? tempCheckPluggedIntoDiagTool;
        public static string? tempDiagnosticReportPath;

        private BrmMainMenuForm parentForm;
        public serviceInspectionForm1(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;

            dbMethods.loadAwaitingServiceInspectionTickets();
            dbMethods.loadStaffNames();
            dbMethods.getRepairOptions();

            twigTicketNumberDropDown.Items.AddRange(dbInformation.activeTwigCaseNumbers.Select(kvp => kvp.Value.ToString()).ToArray());
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Values.ToArray());

            dbInformation.selectedTwigTicketKeyPair.Clear();
            LoadTempVariables();
            dbInformation.TWIGCaseNumber = null;
        }

        private void LoadTempVariables()
        {
            if (dbInformation.TWIGCaseNumber.HasValue && dbInformation.TWIGCaseNumber != 0)
            {
                string? twigValue = tempTwigCaseNumber?.ToString();
                if (twigValue != null && twigTicketNumberDropDown.Items.Contains(twigValue))
                    twigTicketNumberDropDown.SelectedItem = twigValue;
            }
            if (tempCleaningProcedures.HasValue)
            {
                if (tempCleaningProcedures.Value)
                    yesCleanProcButton.Checked = true;
                else
                    noCleanProcedButton.Checked = true;
            }

            if (tempCheckPluggedIntoDiagTool.HasValue)
            {
                if (tempCheckPluggedIntoDiagTool.Value)
                    yesDiagnosticButton.Checked = true;
                else
                    noDiagnosticButton.Checked = true;
            }

            if (!string.IsNullOrEmpty(tempDiagnosticReportPath))
                diagnosticReportPath.Text = tempDiagnosticReportPath;
        }

        private void continueButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (twigTicketNumberDropDown.SelectedItem != null)
                {
                    var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
                    var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == selectedValue);
                    tempSelectedTwigTicketKeyPair.Clear();
                    tempSelectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value;
                }

                if (staffDropDown.SelectedItem != null)
                {
                    var selectedValue = staffDropDown.SelectedItem.ToString();
                    var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value.ToString() == selectedValue);
                    tempSelectedStaffKeyPair.Clear();
                    tempSelectedStaffKeyPair[selectedKvp.Key] = selectedKvp.Value;
                }

                tempCleaningProcedures = yesCleanProcButton.Checked ? true : false;
                tempCheckPluggedIntoDiagTool = yesDiagnosticButton.Checked ? true : false;
                tempDiagnosticReportPath = diagnosticReportPath.Text;
                dbInformation.selectedTwigTicketKeyPair = tempSelectedTwigTicketKeyPair;

                if (!tempSelectedTwigTicketKeyPair.Any())
                {
                    MessageBox.Show("Please select a TWIG ticket number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dbInformation.selectedTwigTicketKeyPair == null)
                {
                    MessageBox.Show("Please select a TWIG ticket number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!tempSelectedStaffKeyPair.Any())
                {
                    MessageBox.Show("Please select a staff member.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tempCleaningProcedures == null)
                {
                    MessageBox.Show("Please select whether cleaning procedures were followed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tempCheckPluggedIntoDiagTool == null)
                {
                    MessageBox.Show("Please select whether diagnostic tool was used.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                parentForm.OpenChildForm(new serviceInspectionForm2(parentForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The following exception was thrown: {ex}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attachFileButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbInformation.diagnosticReportPath = openFileDialog.FileName;
                }
                diagnosticReportPath.Text = dbInformation.diagnosticReportPath; 
            }
        }
    }
}
