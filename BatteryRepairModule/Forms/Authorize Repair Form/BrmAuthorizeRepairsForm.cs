using BatteryRepairModule.Forms.Add_Forms;
using BatteryRepairModule.Forms.BRM;
using BatteryRepairModule.Forms.Quality;
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
        private bool recycled = false;
        public BrmMainMenuForm parentForm;
        public BrmAuthorizeRepairsForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;

            ThemeHelper.ApplyTheme(this);
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
            continueButton.Enabled = false; 
        }

        private void addAuthorizedRepairAction_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
            using (var neForm = new addRepairActionForm(authorizedRepairsListBox, false))
            {
                neForm.ShowDialog(this);
            }
        }

        private void removeAuthorizedRepairAction_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
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
                suggestedRepairsListBox.Items.Clear(); 
                authorizedRepairsListBox.Items.Clear();
                reportedIssuesListBox.Items.Clear(); 

                var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
                var converted = selectedValue.Split('[')[1].Split(']')[0];
                var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == converted);
                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value; ;

                loadReportedIssues();
                loadSuggestedRepairs();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSuggestedRepairs()
        {
            try
            {
                dbMethods.LoadSuggestedRepairs();
                suggestedRepairsListBox.Items.AddRange(dbInformation.proposedRepairsKeyPair.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
                authorizedRepairsListBox.Items.AddRange(dbInformation.proposedRepairsKeyPair.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadReportedIssues()
        {
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
                bool cmd = CheckIfValueNotNullOrLess();
                if (!cmd)
                    return;
                
                cmd = parseAndCheckRecycle();
                if (!cmd)
                    return; 
                

                if (staffDropDown.SelectedItem.ToString() != null)
                    {
                        if (!recycled)
                        {
                            string selectedValue = staffDropDown.SelectedItem.ToString();
                            var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value == selectedValue);
                            dbInformation.selectedStaffKeyValue.Clear();
                            dbInformation.selectedStaffKeyValue[selectedKvp.Key] = selectedKvp.Value;
                        }
                    }

                if (!recycled)
                {
                    bool cond = dbMethods.insertAuthorizedRepairs();
                    if (cond)
                    {
                        MessageBox.Show("Authorized repairs have been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        parentForm.OpenChildForm(new BrmAuthorizeRepairsForm(parentForm));
                        this.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Recycling process has been completed and the form will now close.", "Recycle Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                    continueButton.Enabled = true;
                }
                else
                {
                    addAuthorizedRepairAction.Enabled = false;
                    removeAuthorizedRepairAction.Enabled = false;
                    addTestButton.Enabled = false;
                    continueButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
            using (var newForm = new addTestForm())
                newForm.ShowDialog(this);
        }

        private bool parseAndCheckRecycle()
        {
            try
            {
                foreach (var item in authorizedRepairsListBox.Items)
                {
                    var str = item as string;
                    if (!string.IsNullOrEmpty(str))
                    {
                        var parts = str.Split(new[] { " - " }, 2, StringSplitOptions.None);
                        if (parts.Length == 2)
                        {
                            dbInformation.clearedRepairsKeyValPair[Int16.Parse(parts[0])] = parts[1];
                            if (parts[1] == "RECYCLE")
                            {
                                var recycleResult = MessageBox.Show("Are you sure you want to authorize recycling for this item?", "Confirm Recycle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (recycleResult == DialogResult.No)
                                {
                                    return false;
                                }
                                else if (recycleResult == DialogResult.Yes)
                                {
                                    dbMethods.recycleStatus();
                                    MessageBox.Show("Recycle detected. Recycling process will proceed.", "Recycle Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    recycled = true;
                                    break;
                                }
                            }
                        }
                    }
                } return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfValueNotNullOrLess()
        {
            try
            {
                if (authorizedRepairsListBox.Items.Count == 0)
                {
                    MessageBox.Show("You have no authorized repairs selected. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
