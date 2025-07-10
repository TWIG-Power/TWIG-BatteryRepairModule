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
    public partial class serviceInspectionForm2 : Form
    {
        private BrmMainMenuForm parentForm;
        public byte[] fileBytes; 
        public serviceInspectionForm2(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            this.parentForm = parentRef;

            try
            {
                dbMethods.LoadRegisteredCustomerReport();
                reportedIssuesListBox.Items.AddRange(dbInformation.reportedIssuesList.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbInformation.selectedTwigTicketKeyPair = serviceInspectionForm1.tempSelectedTwigTicketKeyPair;
                dbInformation.selectedStaffKeyValue = serviceInspectionForm1.tempSelectedStaffKeyPair;
                dbInformation.cleaningProcedures = serviceInspectionForm1.tempCleaningProcedures;
                dbInformation.checkPluggedIntoDiagTool = serviceInspectionForm1.tempCheckPluggedIntoDiagTool;
                dbInformation.diagnosticReportPath = serviceInspectionForm1.tempDiagnosticReportPath;

                dbInformation.proposedRepairsKeyPair.Clear(); 
                foreach (var item in repairActionsListBox.Items)
                {
                    var str = item as string;
                    if (!string.IsNullOrEmpty(str))
                    {
                        var parts = str.Split(new[] { " - " }, 2, StringSplitOptions.None);
                        if (parts.Length == 2)
                        {
                            dbInformation.proposedRepairsKeyPair[Int16.Parse(parts[0])] = parts[1];
                        }
                    }
                }
                if (!string.IsNullOrEmpty(dbInformation.diagnosticReportPath))
                {
                    fileBytes = File.ReadAllBytes(dbInformation.diagnosticReportPath);
                }
                else
                {
                    fileBytes = null;
                }

                bool cond1 = dbMethods.createServiceInpsection(fileBytes); 
                bool cond2 = dbMethods.insertSuggestedRepairs();
                if (cond1 && cond2)
                {
                    MessageBox.Show("Service inspection and suggested repairs saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTempValues();
                    this.Close();
                    parentForm.OpenChildForm(new serviceInspectionForm1(parentForm)); 
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to save service inspection or suggested repairs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The following exception was thrown: {ex}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionForm1(parentForm));
        }

        private void addRepairActionButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addRepairActionForm(repairActionsListBox, false))
            {
                newForm.ShowDialog(this);
            }
        }

        private void repairCompletedButton_Click(object sender, EventArgs e)
        {
            if (repairActionsListBox.SelectedItem != null)
                repairActionsListBox.Items.Remove(repairActionsListBox.SelectedItem);
        }
        
        public static void ClearTempValues()
        {
            serviceInspectionForm1.tempTwigCaseNumber = null;
            serviceInspectionForm1.tempSelectedTwigTicketKeyPair.Clear();
            serviceInspectionForm1.tempSelectedStaffKeyPair.Clear(); 
            serviceInspectionForm1.tempCleaningProcedures = null;
            serviceInspectionForm1.tempCheckPluggedIntoDiagTool = null;
            serviceInspectionForm1.tempDiagnosticReportPath = null;
        }
    }
}
