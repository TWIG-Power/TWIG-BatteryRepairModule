﻿using System;
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
        public serviceInspectionForm2(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;

            dbMethods.LoadRegisteredCustomerReport();
            reportedIssuesListBox.Items.AddRange(dbInformation.reportedIssuesList.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
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

                byte[] fileBytes = File.ReadAllBytes(dbInformation.diagnosticReportPath); 

                dbMethods.createServiceInpsection(fileBytes); 
                dbMethods.insertSuggestedRepairs();
                ClearTempValues(); 
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
