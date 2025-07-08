using BatteryRepairModule.Forms.Add_Forms;
using BatteryRepairModule.Forms.BRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.BRM
{
    public partial class BrmAuthorizeRepairsForm : Form
    {
        private List<int> twigTicketKeys = new List<int>();
        public BrmAuthorizeRepairsForm()
        {
            InitializeComponent();

            dbMethods.loadAwaitingAuthorizeRepairTickets();

            twigTicketNumberDropDown.Items.AddRange(
                dbInformation.activeTwigCaseNumbers.Select(kvp =>
                    $"[{kvp.Value}] - {dbInformation.activeModuleSerialNumbers[kvp.Key].ToString()}"
                ).ToArray());

            dbMethods.loadStaffNames();
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Values.ToArray());

            addAuthorizedRepairAction.Enabled = false;
            removeAuthorizedRepairAction.Enabled = false;
            addTestButton.Enabled = false;
        }

        private void addAuthorizedRepairAction_Click(object sender, EventArgs e)
        {
            using (var neForm = new addRepairActionForm(authorizedRepairsListBox, false))
            {
                neForm.ShowDialog(this);
            }
        }

        private void removeAuthorizedRepairAction_Click(object sender, EventArgs e)
        {
            if (authorizedRepairsListBox.SelectedItem != null)
            {
                authorizedRepairsListBox.Items.Remove(authorizedRepairsListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an authorized repair to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
                var converted = selectedValue.Split('[')[1].Split(']')[0]; 
                var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == converted);
                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value;;

                loadReportedIssues();
                loadSuggestedRepairs();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSuggestedRepairs()
        {
            dbMethods.LoadSuggestedRepairs();
            suggestedRepairsListBox.Items.AddRange(dbInformation.proposedRepairsKeyPair.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
            authorizedRepairsListBox.Items.AddRange(dbInformation.proposedRepairsKeyPair.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
        }

        private void loadReportedIssues()
        {
            dbMethods.LoadRegisteredCustomerReport();
            reportedIssuesListBox.Items.AddRange(dbInformation.reportedIssuesList.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (reportedIssuesListBox.Items.Count > authorizedRepairsListBox.Items.Count)
            {
                var result = MessageBox.Show("The amount of repair actions is less than the amount of reported issues. Are you sure you wish to proceed?", "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else if (authorizedRepairsListBox.Items.Count == 0)
            {
                MessageBox.Show("You have no authorized repairs selected. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var item in authorizedRepairsListBox.Items)
            {
                var str = item as string;
                if (!string.IsNullOrEmpty(str))
                {
                    var parts = str.Split(new[] { " - " }, 2, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        dbInformation.clearedRepairsKeyValPair[Int16.Parse(parts[0])] = parts[1];
                    }
                }
            }

            if (staffDropDown.SelectedItem.ToString() != null)
            {
                string selectedValue = staffDropDown.SelectedItem.ToString();
                var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value == selectedValue);
                dbInformation.selectedStaffKeyValue.Clear();
                dbInformation.selectedStaffKeyValue[selectedKvp.Key] = selectedKvp.Value;
            }

            dbMethods.insertAuthorizedRepairs();
            this.Close();
        }

        private void staffDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = staffDropDown.Text;
                if (staffDropDown.Items.Contains(selectedValue))
                {
                    var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value == selectedValue);
                    dbInformation.selectedStaffKeyValue.Clear();
                    dbInformation.selectedStaffKeyValue[selectedKvp.Key] = selectedKvp.Value;

                    addAuthorizedRepairAction.Enabled = true;
                    removeAuthorizedRepairAction.Enabled = true;
                    addTestButton.Enabled = true;
                }
                else
                {
                    addAuthorizedRepairAction.Enabled = false;
                    removeAuthorizedRepairAction.Enabled = false;
                    addTestButton.Enabled = false;
                }
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addTestForm())
                newForm.ShowDialog(this); 
        }
    }
}
