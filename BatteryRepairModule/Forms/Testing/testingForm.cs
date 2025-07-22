using BatteryRepairModule.Forms.Add_Forms;
using BatteryRepairModule.Forms.BRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Testing
{
    public partial class testingForm : Form
    {
        private BrmMainMenuForm parentForm;
        private List<string> temp = new List<string>();
        public testingForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            parentForm = parentRef;
            ThemeHelper.ApplyTheme(this);
            dbMethods.loadModulesAwaitingTesting();
            foreach (Module module in dbInformation.activeModules)
            {
                twigTicketNumberDropDown.Items.Add($"[{module.ticketId}] - [{module.model}] - {module.SerialNumber}");
            }

            dbMethods.loadStaffTesting();
            staffDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Select(kvp => kvp.Value.ToString()).ToArray());

            dbMethods.getTestingOptions();

            addRequiredTestButton.Enabled = false;
            viewTestNoteButton.Enabled = false;
            addTestNoteButton.Enabled = false;
            updateTestStatus.Enabled = false;
            returnBatteryToRepairButton.Enabled = false;
            clearBatteryForQualityButton.Enabled = false;
            viewRepairNoteButton.Enabled = false;
            diagnosticReportButton.Enabled = false;
            staffDropDown.Enabled = false; 

        }

        private void addTestNoteButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
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
            staffDropDown.Enabled = false;
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
            staffDropDown.Enabled = false;
            using (var newForm = new addTestForm())
            {
                newForm.ShowDialog(this);
            }

            testStatusListBox.Items.Clear();
            dbMethods.getDoesTestHaveNote();
            dbMethods.getAddedTestsByTwigTicket();
            foreach (var kvp in dbInformation.addedTestsKeyValue)
            {
                var testId = kvp.Key;
                var testName = kvp.Value;
                var status = dbInformation.addedTestsKeyStatus.GetValueOrDefault(testId);

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

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
                var converted = selectedValue.Split('[')[1].Split(']')[0];
                var selectedKvp = dbInformation.activeModules.FirstOrDefault(mod => mod.ticketId.ToString() == converted);
                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair[selectedKvp.ticketSurrogateKey] = selectedKvp.ticketId;

                staffDropDown.Enabled = true; 

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

                if (!dbInformation.addedTestsKeyValue.Any())
                {
                    dbInformation.tempAddNewTest.Clear();
                    dbInformation.tempAddNewTest.Add(dbInformation.testingOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == "Cycle Test").Key, "");
                    dbMethods.insertNewTestAction();

                    dbMethods.getAddedTestsByTwigTicket();

                    temp.Clear();

                    foreach (var kvp in dbInformation.addedTestsKeyValue)
                    {
                        var testId = kvp.Key;
                        var testName = kvp.Value;
                        var status = dbInformation.addedTestsKeyStatus.GetValueOrDefault(testId);
                        temp.Add($"[{testId}] {testName} ({status})");
                    }

                    temp.Sort();

                    testStatusListBox.Items.AddRange(temp.ToArray());
                }

                temp.Clear();

                foreach (var kvp in dbInformation.addedTestsKeyValue)
                {
                    var testId = kvp.Key;
                    var testName = kvp.Value;
                    var status = dbInformation.addedTestsKeyStatus.GetValueOrDefault(testId);

                    if (dbInformation.doesTestHaveNote[testId] == false)
                    {
                        temp.Add($"[{testId}] {testName} ({status})");
                    }
                    else
                    {
                        temp.Add($"[{testId}] {testName} ({status})*");
                    }
                }

                temp.Sort();

                testStatusListBox.Items.AddRange(temp.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            viewRepairNoteButton.Enabled = true;
            diagnosticReportButton.Enabled = true; 
        }

        private void returnBatteryToRepairButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
            var result = MessageBox.Show("Are you sure you wish to return module to repair actions?", "Confirm Module To Repair Actions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            bool cond = dbMethods.returnModuleToRepairActions();
            if (cond)
            {
                MessageBox.Show("Module returned to repair actions", "Module returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                parentForm.OpenChildForm(new testingForm(parentForm));
                return;
            }
        }

        private void updateTestStatus_Click_1(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
            if (testStatusListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a test from the list to update its status.", "No Test Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = testStatusListBox.SelectedItem.ToString();
            string parsed = selectedItem.Split(']')[1].Split('(')[0].Trim();
            var kvp = dbInformation.testingOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == parsed);
            Dictionary<int, string> tempDict = new Dictionary<int, string>
            {
                { kvp.Key, kvp.Value }
            };

            // does it require input??
            bool reqInput = dbInformation.testingOptionsRequiredKeyBoolean[kvp.Key];

            if (!reqInput)
            {
                using (var newForm = new addStatusUpdateForm(testStatusListBox, "Test"))
                    newForm.ShowDialog(this);
            }
            else
            {
                using (var tempForm = new stateOfHealthCalculatorForm(testStatusListBox))
                {
                    tempForm.ShowDialog(this);
                    if (dbInformation.conditionalClosureFailure)
                    {
                        return;
                    }
                }
            }
        }

        private void clearBatteryForQualityButton_Click(object sender, EventArgs e)
        {
            if (testStatusListBox.Items.Count == 0)
            {
                MessageBox.Show("At least one test is required before clearing the battery for quality.", "No Tests Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            staffDropDown.Enabled = false;
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
            bool cond = dbMethods.clearModuleForQuality();
            if (cond)
            {
                MessageBox.Show("Module cleared for quality.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentForm.OpenChildForm(new testingForm(parentForm));
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Failed to clear module for quality. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewRepairNoteButton_Click(object sender, EventArgs e)
        {
            staffDropDown.Enabled = false;
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

        private void diagnosticReportButton_Click(object sender, EventArgs e)
        {
            byte[] file = dbMethods.pullDiagnosticFile(dbInformation.selectedTwigTicketKeyPair.Keys.First());
            if (file != null && file.Length > 0)
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BRM Diagnostic Reports"); // Save in "BRM Diagnostic Reports" folder on Desktop
                Directory.CreateDirectory(folderPath); 

                string fileName = $"{dbInformation.selectedTwigTicketKeyPair.Values.First()}_DiagnosticReport.html";
                string filePath = Path.Combine(folderPath, fileName);

                if (File.Exists(filePath))
                {
                    var result = MessageBox.Show("File already exists. Would you like to replace?", "Warning: File Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        File.WriteAllBytes(filePath, file);
                        MessageBox.Show("Diagnostic report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    File.WriteAllBytes(filePath, file);
                    MessageBox.Show("Diagnostic report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
            else
            {
                var attachResult = MessageBox.Show("No diagnostic report found. Would you like to attach one?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (attachResult == DialogResult.Yes)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|HTML Files (*.html;*.htm)|*.html;*.htm";
                        openFileDialog.Title = "Select Diagnostic Report PDF/HTML";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                            bool uploadSuccess = dbMethods.attachDiagnosticFile(fileBytes);
                            if (uploadSuccess)
                            {
                                MessageBox.Show("Diagnostic report attached successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to attach diagnostic report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
