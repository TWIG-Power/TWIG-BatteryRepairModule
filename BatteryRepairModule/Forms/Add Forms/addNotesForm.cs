using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Add_Forms
{
    public partial class addNotesForm : Form
    {
        private bool viewOnly;
        private ListBox referenceListBox;
        private string localTable;
        public addNotesForm(ListBox passedListBox, bool viewOnlyRef, string table)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            this.viewOnly = viewOnlyRef;
            this.referenceListBox = passedListBox;
            this.localTable = table;

            // Reset the variable used to load the selected repair
            dbInformation.tempUpdateNotesRepairHolder.Clear();

            if (viewOnly)
            {
                switch (table)
                {
                    case "repair":
                        viewOnlyRepair();
                        break;
                    case "test":
                        viewOnlyTest(); 
                        break;
                    default:
                        break;
                }
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (viewOnly)
            {
                this.Close();
            }
            else
            {
                switch (localTable)
                {
                    case "repair":

                        dbInformation.tempUpdateNotesRepairHolder.Clear(); 
                        var selectedValue = referenceListBox.SelectedItem as string;
                        var selectedRepaired = selectedValue?.Split('(')[0].Trim();
                        var selectedKvp = dbInformation.clearedRepairsKeyValPair.FirstOrDefault(kvp => kvp.Value.ToString() == selectedRepaired);
                        dbInformation.tempUpdateNotesRepairHolder[selectedKvp.Key] = selectedKvp.Value;
                        dbInformation.repairNotes = richTextBox1.Text.ToString();
                        dbMethods.updateRepairNotes();

                        break;

                    case "test":

                        dbInformation.tempTestNoteHolder.Clear();
                        var selectedValue2 = referenceListBox.SelectedItem as string;
                        if (!string.IsNullOrEmpty(selectedValue2))
                        {
                            var selectedId = int.Parse(selectedValue2.Split(']')[0].TrimStart('[')); 
                            dbInformation.tempTestNoteHolder[selectedId] = dbInformation.addedTestsKeyValue[selectedId];
                            dbInformation.testNotes = richTextBox1.Text.ToString();
                            dbMethods.updateTestNotes();

                            referenceListBox.Items.Clear(); 
                            dbMethods.getDoesTestHaveNote(); 
                            dbMethods.getAddedTestsByTwigTicket();

                            foreach (var kvp in dbInformation.addedTestsKeyValue)
                            {
                                var testId = kvp.Key;
                                var testName = kvp.Value; 
                                var status = dbInformation.addedTestsKeyStatus.GetValueOrDefault(testId); // Test status

                                if (dbInformation.doesTestHaveNote[testId] == false)
                                {
                                    referenceListBox.Items.Add($"[{testId}] {testName} ({status})");
                                }
                                else
                                {
                                    referenceListBox.Items.Add($"[{testId}] {testName} ({status})*");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No test selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    default:
                        break;
                }
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewOnlyRepair()
        {
            {
                var selectedValue = referenceListBox.SelectedItem as string;
                if (!string.IsNullOrEmpty(selectedValue))
                {
                    var selectedRepaired = selectedValue.Split('(')[0].Trim();
                    var selectedKvp = dbInformation.clearedRepairsKeyValPair.FirstOrDefault(kvp => kvp.Value.ToString() == selectedRepaired);

                    if (selectedKvp.Key != 0)
                    {
                        dbInformation.tempUpdateNotesRepairHolder.Clear();
                        dbInformation.tempUpdateNotesRepairHolder[selectedKvp.Key] = selectedKvp.Value;

                        dbInformation.repairNotes = string.Empty;
                        dbMethods.getRepairNotes();

                        richTextBox1.Enabled = false;
                        richTextBox1.Text = dbInformation.repairNotes;
                    }
                    else
                    {
                        MessageBox.Show("Selected repair not found in the dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No repair selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewOnlyTest()
        {
            var selectedValue = referenceListBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedValue))
            {
                var selectedTest = selectedValue.Split('(')[0].Trim();
                selectedTest = selectedTest.Split(']')[1].Trim();
                var selectedKvp = dbInformation.testingOptionsKeyValue.FirstOrDefault(kvp => kvp.Value.ToString() == selectedTest);

                if (selectedKvp.Key != 0)
                {
                    dbInformation.tempTestNoteHolder.Clear();
                    dbInformation.tempTestNoteHolder[selectedKvp.Key] = selectedKvp.Value;

                    dbInformation.testNotes = string.Empty;
                    dbMethods.getTestNotes();

                    richTextBox1.Enabled = false;
                    richTextBox1.Text = dbInformation.testNotes;
                }
                else
                {
                    MessageBox.Show("Selected test not found in the dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                    }
                }
                else
                {
                    MessageBox.Show("No test selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
