using BatteryRepairModule.Forms.Add_Forms;
using BatteryRepairModule.Forms.BRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.BRM
{
    public partial class BrmRepairActionForm : Form
    {
        public BrmRepairActionForm()
        {
            InitializeComponent();

            dbMethods.loadAwaitingRepairActionsStatus();
            twigTicketNumberDropDown.Items.AddRange(dbInformation.activeTwigCaseNumbers.Select(kvp => kvp.Value.ToString()).ToArray());

            dbMethods.loadStaffNames();
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Values.ToArray());

            addRepairActionButton.Enabled = false;
            viewRepairNotesButton.Enabled = false;
            addRepairNotesButton.Enabled = false;
            updateIssueStatus.Enabled = false;
            updateRepairStatus.Enabled = false;
        
        }

        // Update Issue Status
        private void continueButton_Click_1(object sender, EventArgs e)
        {
            using (var newForm = new addStatusUpdateForm(reportedIssuesListBox, "Issue"))
            {
                newForm.ShowDialog(this);
            }
        }

        // Update Repair Status
        private void backButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addStatusUpdateForm(repairActionsListBox, "Repair"))
                newForm.ShowDialog(this); 
        }

        // Add Repair Actions
        private void addRepairActionButton_Click_2(object sender, EventArgs e)
        {
            using (var newForm = new addRepairActionForm(repairActionsListBox, true))
                newForm.ShowDialog(this);
        }

        // CHANGED TO VIEW REPAIR NOTES
        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addNotesForm(repairActionsListBox, true))
                newForm.ShowDialog(this); 
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportedIssuesListBox.Items.Clear();
            repairActionsListBox.Items.Clear();

            if (twigTicketNumberDropDown.SelectedItem.ToString() != null)
            {
                string selectedItem = twigTicketNumberDropDown.SelectedItem.ToString();
                var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == selectedItem);
                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value;
            }


            dbMethods.loadReportedIssuesAndStatus();
            reportedIssuesListBox.Items.AddRange(dbInformation.reportedIssuesValueStatus.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray()); 

            dbMethods.loadRepairActionKeyValueStatus();
            repairActionsListBox.Items.AddRange(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());
        }

        private void staffDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = staffDropDown.SelectedItem.ToString();
            var selectedKey = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value.ToString() == selectedValue);
            dbInformation.selectedStaffKeyValue.Clear();
            dbInformation.selectedStaffKeyValue[selectedKey.Key] = selectedKey.Value;

            addRepairActionButton.Enabled = true;
            viewRepairNotesButton.Enabled = true;
            addRepairNotesButton.Enabled = true;
            updateIssueStatus.Enabled = true;
            updateRepairStatus.Enabled = true;
            
        }

        // Add Repair Notes
        private void button1_Click(object sender, EventArgs e)
        {
            using (var newForm = new addNotesForm(repairActionsListBox, false))
                newForm.ShowDialog(this); 
        }
    }
}
