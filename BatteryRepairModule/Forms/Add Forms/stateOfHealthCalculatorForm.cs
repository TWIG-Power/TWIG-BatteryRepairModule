using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BatteryRepairModule.Forms.Add_Forms
{
    public partial class stateOfHealthCalculatorForm : Form
    {
        int inputedValue = 0;
        private ListBox importedListBox;
        private string writtenStateOfHealth = string.Empty; 
        private List<string> temp = new List<string>(); 

        public stateOfHealthCalculatorForm(ListBox refListbox)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            dbMethods.getModuleType();
            dbMethods.getStateOfHealthRanges();
            dbMethods.getTestStatusOptions();
            this.importedListBox = refListbox;
            moduleTypeChangeLabel.Text = dbInformation.moduleTypeKeyValue.Values.First();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                inputedValue = Int32.Parse(maskedTextBox1.Text.ToString());
                if (inputedValue <= dbInformation.raceGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.raceGradeHighLowKeyPair.Values.First())
                {
                    stateOfHealthGradeChangeLabel.Text = "Race Grade";
                    stateOfHealthRangeChangeLabel.Text = $"{dbInformation.raceGradeHighLowKeyPair.Keys.First()} - {dbInformation.raceGradeHighLowKeyPair.Values.First()}";
                }
                else if (inputedValue <= dbInformation.trackGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.trackGradeHighLowKeyPair.Values.First())
                {
                    stateOfHealthGradeChangeLabel.Text = "Track Grade";
                    stateOfHealthRangeChangeLabel.Text = $"{dbInformation.trackGradeHighLowKeyPair.Keys.First()} - {dbInformation.trackGradeHighLowKeyPair.Values.First()}";
                }
                else if (inputedValue <= dbInformation.playGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.playGradeHighLowKeyPair.Values.First())
                {
                    stateOfHealthGradeChangeLabel.Text = "Play Grade";
                    stateOfHealthRangeChangeLabel.Text = $"{dbInformation.playGradeHighLowKeyPair.Keys.First()} - {dbInformation.playGradeHighLowKeyPair.Values.First()}";
                }
                else
                {
                    MessageBox.Show("Value is out of range. Please check the values and try again.", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                writtenStateOfHealth = stateOfHealthGradeChangeLabel.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputTextbox_textChanged(object sender, EventArgs e) {
            try
            {
                inputedValue = Int32.Parse(maskedTextBox1.Text.ToString());
                if (inputedValue <= dbInformation.raceGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.raceGradeHighLowKeyPair.Values.First())
                {
                    stateOfHealthGradeChangeLabel.Text = "Race Grade";
                    stateOfHealthRangeChangeLabel.Text = $"{dbInformation.raceGradeHighLowKeyPair.Values.First()} - {dbInformation.raceGradeHighLowKeyPair.Keys.First()}";
                }
                else if (inputedValue <= dbInformation.trackGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.trackGradeHighLowKeyPair.Values.First())
                {
                    stateOfHealthGradeChangeLabel.Text = "Track Grade";
                    stateOfHealthRangeChangeLabel.Text = $"{dbInformation.trackGradeHighLowKeyPair.Values.First()} - {dbInformation.trackGradeHighLowKeyPair.Keys.First()}";
                }
                else if (inputedValue <= dbInformation.playGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.playGradeHighLowKeyPair.Values.First())
                {
                    stateOfHealthGradeChangeLabel.Text = "Play Grade";
                    stateOfHealthRangeChangeLabel.Text = $"{dbInformation.playGradeHighLowKeyPair.Values.First()} - {dbInformation.playGradeHighLowKeyPair.Keys.First()}";
                }
                else
                {
                    stateOfHealthGradeChangeLabel.Text = "NULL";
                    stateOfHealthRangeChangeLabel.Text = "NULL";
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTestString = importedListBox.SelectedItem as string;
                var selectedTest = selectedTestString?.Split('(')[0].Trim();
                var finalSelectedTest = selectedTest?.Split(']')[1].Trim();
                var selectedKvpp = dbInformation.addedTestsKeyValue.FirstOrDefault(kvp => kvp.Value == (string?)finalSelectedTest);
                dbInformation.tempTestTestHolder.Clear();
                dbInformation.tempTestTestHolder[selectedKvpp.Key] = selectedKvpp.Value;

                dbInformation.tempTestStatusHolder.Clear();

                if (Int32.Parse(maskedTextBox1.Text) > dbInformation.raceGradeHighLowKeyPair.Keys.First() || Int32.Parse(maskedTextBox1.Text) < dbInformation.playGradeHighLowKeyPair.Values.First())
                {
                    var kvp = dbInformation.testStatusOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == "Fail");
                    dbInformation.tempTestStatusHolder[kvp.Key] = kvp.Value;
                }
                else
                {
                    var kvp = dbInformation.testStatusOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == "Pass");
                    dbInformation.tempTestStatusHolder[kvp.Key] = kvp.Value;
                }

                dbInformation.conditionalClosureFailure = false;
                dbMethods.updateTestStatus(writtenStateOfHealth);

                dbMethods.getDoesTestHaveNote();
                dbMethods.getAddedTestsByTwigTicket();
                importedListBox.Items.Clear();

                temp.Clear();

                foreach (var kvp in dbInformation.addedTestsKeyValue)
                {
                    var testId = kvp.Key; // Unique ID of the test
                    var testName = kvp.Value; // Test name
                    var status = dbInformation.addedTestsKeyStatus.GetValueOrDefault(testId); // Test status


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
                importedListBox.Items.AddRange(temp.ToArray());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dbInformation.conditionalClosureFailure = true; 
            this.Close(); 
        }
    }
}
