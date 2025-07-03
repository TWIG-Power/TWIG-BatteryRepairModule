using BatteryRepairModule.Forms.Add_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Testing
{
    public partial class testingForm : Form
    {
        public testingForm()
        {
            InitializeComponent();

            dbMethods.loadAwaitingTestingTickets();
            twigTicketNumberDropDown.Items.AddRange(dbInformation.activeTwigCaseNumbers.Select(kvp => kvp.Value.ToString()).ToArray());

            dbMethods.loadStaffNames();
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Select(kvp => kvp.Value.ToString()).ToArray());

            dbMethods.getTestingOptions();

            addRequiredTestButton.Enabled = false;
            viewTestNoteButton.Enabled = false;
            addTestNoteButton.Enabled = false;
            updateTestStatus.Enabled = false;
            returnBatteryToRepairButton.Enabled = false;
            clearBatteryForQualityButton.Enabled = false;
            calculateStateOfHealthButton.Enabled = false;
            viewRepairNoteButton.Enabled = false; 

        }

        private void addTestNoteButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addNotesForm(testStatusListBox, false, "test"))
                if (testStatusListBox.SelectedItem != null)
                {
                    newForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Please select a test to add a note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void viewTestNoteButton_Click(object sender, EventArgs e)
        {
            if (testStatusListBox.SelectedItem != null)
            {
                using (var newForm = new addNotesForm(testStatusListBox, true, "test"))
                    newForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select a test to view its note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRequiredTestButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addTestForm())
            {
                newForm.ShowDialog(this);
            }

            testStatusListBox.Items.Clear();
            dbMethods.getAddedTestsByTwigTicket();
            testStatusListBox.Items.AddRange(
                dbInformation.addedTestsKeyValue.Select(
                    kvp => $"{kvp.Value} ({dbInformation.addedTestsKeyStatus.GetValueOrDefault(kvp.Key)})").ToArray()
            );

        }

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = twigTicketNumberDropDown.SelectedItem as string;
            var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == selectedItem);
            dbInformation.selectedTwigTicketKeyPair.Clear();
            dbInformation.selectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value;

            repairActionsListBox.Items.Clear();
            dbMethods.loadRepairActionKeyValueStatus();
            repairActionsListBox.Items.AddRange(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());

            testStatusListBox.Items.Clear();
            dbMethods.getAddedTestsByTwigTicket();
            testStatusListBox.Items.AddRange(
                dbInformation.addedTestsKeyValue.Select(
                    kvp => $"{kvp.Value} ({dbInformation.addedTestsKeyStatus.GetValueOrDefault(kvp.Key)})").ToArray()
            );
        }

        private void staffDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = staffDropDown.SelectedItem as string;
            var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value.ToString() == selectedItem);
            dbInformation.selectedStaffKeyValue.Clear();
            dbInformation.selectedStaffKeyValue[selectedKvp.Key] = selectedKvp.Value;

            addRequiredTestButton.Enabled = true;
            addTestNoteButton.Enabled = true;
            viewTestNoteButton.Enabled = true;
            updateTestStatus.Enabled = true;
            returnBatteryToRepairButton.Enabled = true;
            clearBatteryForQualityButton.Enabled = true;
            calculateStateOfHealthButton.Enabled = true;
            viewRepairNoteButton.Enabled = true; 
        }

        private void viewRepairActionNotesButton_Click(object sender, EventArgs e)
        {
            if (repairActionsListBox.SelectedItem != null)
            {
                using (var newForm = new addNotesForm(repairActionsListBox, true, "test"))
                {
                    newForm.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Please select a repair action to view its note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnBatteryToRepairButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to return module to repair actions?", "Confirm Module To Repair Actions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            dbMethods.returnModuleToRepairActions();
            MessageBox.Show("Module returned to repair actions", "Module returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void calculateStateOfHealthButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new stateOfHealthCalculatorForm())
                newForm.ShowDialog(this);
        }

        private void updateTestStatus_Click_1(object sender, EventArgs e)
        {
            if (testStatusListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a test from the list to update its status.", "No Test Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var newForm = new addStatusUpdateForm(testStatusListBox, "Test"))
                newForm.ShowDialog(this);
        }

        private void clearBatteryForQualityButton_Click(object sender, EventArgs e)
        {

        }

        private void viewRepairNoteButton_Click(object sender, EventArgs e)
        {
            if (repairActionsListBox.SelectedItem != null)
            {
            using (var newForm = new addNotesForm(repairActionsListBox, true, "repair"))
                newForm.ShowDialog(this);
            }
            else
            {
            MessageBox.Show("Please select a repair action to view its note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
