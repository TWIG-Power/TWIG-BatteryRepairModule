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
        public stateOfHealthCalculatorForm(ListBox refListbox)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            dbMethods.getModuleType();
            dbMethods.getStateOfHealthRanges();
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

                if (Int32.Parse(maskedTextBox1.Text) > dbInformation.raceGradeHighLowKeyPair.Keys.First() || Int32.Parse(maskedTextBox1.Text) < dbInformation.playGradeHighLowKeyPair.Values.First())
                {
                    MessageBox.Show("Value is out of range. Please check the values and try again.", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbInformation.conditionalClosureFailure = false; 
                dbMethods.insertStateOfHealth(writtenStateOfHealth);
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
