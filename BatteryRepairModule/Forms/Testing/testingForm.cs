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

        }

        private void addTestNoteButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addNotesForm(testStatusListBox, false, "test"))
                newForm.ShowDialog(this); 
        }

        private void testStatusListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewTestNoteButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addNotesForm(testStatusListBox, true, "test"))
                newForm.ShowDialog(this); 
        }

        private void addRequiredTestButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addTestForm())
            {
                newForm.ShowDialog(this);
            }
        }

        private void updateTestStatusButton_Click(object sender, EventArgs e)
        {

        }

        private void repairActionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        }
    }
}
