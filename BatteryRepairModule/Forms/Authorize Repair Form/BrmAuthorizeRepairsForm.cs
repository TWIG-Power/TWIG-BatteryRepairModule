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
            
            foreach (var kvp in dbInformation.activeTwigCaseNumbers)
            {
                twigTicketNumberDropDown.Items.Add(kvp.Value);
                twigTicketKeys.Add(kvp.Key);
            }

            dbMethods.loadStaffNames();
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Values.ToArray());

            addAuthorizedRepairAction.Enabled = false;
            removeAuthorizedRepairAction.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

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
            authorizedRepairsListBox.Items.Remove(authorizedRepairsListBox.SelectedItem);
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                reportedIssuesListBox.Items.Clear();
                suggestedRepairsListBox.Items.Clear();
                authorizedRepairsListBox.Items.Clear();

                int selectedIndex = twigTicketNumberDropDown.SelectedIndex;
                int selectedKey = twigTicketKeys[selectedIndex];

                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair.Add(selectedKey, dbInformation.activeTwigCaseNumbers[selectedKey]);

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
            addAuthorizedRepairAction.Enabled = true;
            removeAuthorizedRepairAction.Enabled = true; 
        }
    }
}
