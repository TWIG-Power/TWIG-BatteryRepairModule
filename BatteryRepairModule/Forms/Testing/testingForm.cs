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
            twigTicketNumberDropDown.Items.AddRange(
                dbInformation.activeTwigCaseNumbers.Select(kvp =>
                    $"[{kvp.Value}] - {dbInformation.activeModuleSerialNumbers[kvp.Key].ToString()}"
                ).ToArray());

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
            if (testStatusListBox.SelectedItem != null)
            {
                using (var newForm = new addNotesForm(testStatusListBox, false, "test"))
                {
                    newForm.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Please select a test to add a note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
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
                return; 
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
            var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
            var converted = selectedValue.Split('[')[1].Split(']')[0]; 
            var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == converted);
            dbInformation.selectedTwigTicketKeyPair.Clear();
            dbInformation.selectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value;;

            repairActionsListBox.Items.Clear();

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

            testStatusListBox.Items.Clear();

            dbMethods.getDoesTestHaveNote(); 
            dbMethods.getAddedTestsByTwigTicket();

            foreach (var kvp in dbInformation.addedTestsKeyValue)
            {
                var testId = kvp.Key; // Unique ID of the test
                var testName = kvp.Value; // Test name
                var status = dbInformation.addedTestsKeyStatus.GetValueOrDefault(testId); // Test status

                if (dbInformation.doesTestHaveNote[testId] == false)
                {
                    testStatusListBox.Items.Add($"[{testId}] {testName} ({status})");
                }
                else
                {
                    testStatusListBox.Items.Add($"[{testId}] {testName} ({status})*");
                }
            }
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
            var selectedTest = testStatusListBox.SelectedItem;
            if (selectedTest == null)
            {
                MessageBox.Show("No test selected. Please select a test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var newForm = new stateOfHealthCalculatorForm(testStatusListBox))
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
            foreach (var test in testStatusListBox.Items)
            {
                var status = test.ToString();
                string cutStatus = status.Split('(')[1].Split(')')[0];
                if (cutStatus != "Pass")
                {
                    MessageBox.Show("Not all tests have been passed. Please try again.", "Missing Test Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            dbMethods.clearModuleForQuality();
            this.Close();
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
