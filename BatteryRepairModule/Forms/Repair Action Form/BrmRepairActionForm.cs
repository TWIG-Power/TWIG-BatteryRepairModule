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
        private BrmMainMenuForm parentForm;
        public BrmRepairActionForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;
            ThemeHelper.ApplyTheme(this);

            dbMethods.loadModulesAwaitingRepairAction();
            foreach (Module module in dbInformation.activeModules)
            {
                twigTicketNumberDropDown.Items.Add($"[{module.ticketId}] - [{module.model}] - {module.SerialNumber}");
            }

            dbMethods.loadStaffRepairActions();
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Values.ToArray());

            addRepairActionButton.Enabled = false;
            viewRepairNotesButton.Enabled = false;
            addRepairNotesButton.Enabled = false;
            updateIssueStatus.Enabled = false;
            updateRepairStatus.Enabled = false;
            addTestButton.Enabled = false;
            clearModuleForTestingButton.Enabled = false;
            staffDropDown.Enabled = false; 

        }

        // Update Issue Status
        private void continueButton_Click_1(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false; 

            if (reportedIssuesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an issue before updating its status.", "No Issue Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var newForm = new addStatusUpdateForm(reportedIssuesListBox, "Issue"))
            {
                newForm.ShowDialog(this);
            }
        }

        // Add Repair Actions
        private void addRepairActionButton_Click_2(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;

            using (var newForm = new addRepairActionForm(repairActionsListBox, true))
                newForm.ShowDialog(this);
            if (dbInformation.recycled == true)
            {
                this.Close();
                parentForm.OpenChildForm(new BrmRepairActionForm(parentForm)); 
            }
        }

        //VIEW REPAIR NOTES
        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false; 
            if (repairActionsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a repair action before viewing notes.", "No Repair Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var newForm = new addNotesForm(repairActionsListBox, true, "repair"))
                newForm.ShowDialog(this);
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reportedIssuesListBox.Items.Clear();
                repairActionsListBox.Items.Clear();
                staffDropDown.Enabled = true; 

                if (twigTicketNumberDropDown.SelectedItem.ToString() != null)
                {
                    var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
                    var converted = Int32.Parse(selectedValue.Split('[')[1].Split(']')[0]);
                    var selectedKvp = dbInformation.activeModules.FirstOrDefault(module => module.ticketId == converted);
                    dbInformation.selectedTwigTicketKeyPair.Clear();
                    dbInformation.selectedTwigTicketKeyPair[selectedKvp.ticketSurrogateKey] = selectedKvp.ticketId;
                }


                dbMethods.loadReportedIssuesAndStatus();
                reportedIssuesListBox.Items.AddRange(dbInformation.reportedIssuesValueStatus.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());

                dbMethods.getDoesRepairHaveNote(); 

                dbMethods.loadRepairActionKeyValueStatus();
                foreach (var kvp in dbInformation.clearedRepairsValueStatusPair)
                {
                    if (dbInformation.repairHasNoteStringBool[kvp.Key] == false)
                        repairActionsListBox.Items.Add($"{kvp.Key} ({kvp.Value})");
                    else
                    {
                        repairActionsListBox.Items.Add($"{kvp.Key} ({kvp.Value})*");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            addTestButton.Enabled = true;
            clearModuleForTestingButton.Enabled = true;

        }

        // Add Repair Notes
        private void button1_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false; 
            if (repairActionsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a repair action before adding notes.", "No Repair Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var newForm = new addNotesForm(repairActionsListBox, false, "repair"))
                newForm.ShowDialog(this);
        }

        private void updateRepairStatus_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false; 
            if (repairActionsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a repair action before updating its status.", "No Repair Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var newForm = new addStatusUpdateForm(repairActionsListBox, "Repair"))
                newForm.ShowDialog(this);
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false; 
            using (var newForm = new addTestForm())
                newForm.ShowDialog(this);
        }

        private void clearModuleForTestingButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false; 
            foreach (string item2 in reportedIssuesListBox.Items)
            {
                if (string.IsNullOrEmpty(item2)) continue;
                int parentIndex = item2.LastIndexOf('(');
                string status = string.Empty;
                if (parentIndex > 0)
                {
                    status = item2.Substring(parentIndex + 1).TrimEnd(')', ' ');
                }
                if (status != "Resolved")
                {
                    MessageBox.Show("This module has issues that haven't been resolved yet.", "Unresolved Issues", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (string item in repairActionsListBox.Items)
            {
                if (string.IsNullOrEmpty(item)) continue;
                int parenIndex = item.LastIndexOf('(');
                string status = string.Empty;
                if (parenIndex > 0)
                {
                    status = item.Substring(parenIndex + 1).TrimEnd(')', '*');
                }
                if (status != "Complete")
                {
                    MessageBox.Show("This module has repairs that haven't been completed yet.", "Unresolved Repairs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool cond = dbMethods.clearModuleForTesting();
            if (cond)
            {
                MessageBox.Show("Module has been cleared for testing", "Cleared For Testing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                parentForm.OpenChildForm(new BrmRepairActionForm(parentForm));
                return;
            }
            else
            {
            MessageBox.Show("Failed to clear the module for testing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
    }
}
