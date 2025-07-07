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
        public stateOfHealthCalculatorForm(ListBox refListbox)
        {
            InitializeComponent();
            dbMethods.getModuleType();
            this.importedListBox = refListbox; 
            moduleTypeChangeLabel.Text = dbInformation.moduleTypeKeyValue.Values.First();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            inputedValue = Int32.Parse(maskedTextBox1.Text.ToString());
            if (inputedValue <= dbInformation.raceGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.raceGradeHighLowKeyPair.Values.First())
            {
                stateOfHealthGradeChangeLabel.Text = "Race Grade";
                stateOfHealthRangeChangeLabel.Text = $"{dbInformation.raceGradeHighLowKeyPair.Keys.First()} - {dbInformation.raceGradeHighLowKeyPair.Values.First()}";
            }
            if (inputedValue <= dbInformation.trackGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.trackGradeHighLowKeyPair.Values.First())
            {
                stateOfHealthGradeChangeLabel.Text = "Track Grade";
                stateOfHealthRangeChangeLabel.Text = $"{dbInformation.trackGradeHighLowKeyPair.Keys.First()} - {dbInformation.trackGradeHighLowKeyPair.Values.First()}";
            }
            if (inputedValue <= dbInformation.playGradeHighLowKeyPair.Keys.First() && inputedValue >= dbInformation.playGradeHighLowKeyPair.Values.First())
            {
                stateOfHealthGradeChangeLabel.Text = "Play Grade";
                stateOfHealthRangeChangeLabel.Text = $"{dbInformation.playGradeHighLowKeyPair.Keys.First()} - {dbInformation.playGradeHighLowKeyPair.Values.First()}"; 
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTestString = importedListBox.SelectedItem as string;
                var selectedTest = selectedTestString?.Split('(')[0].Trim();
                var selectedKvpp = dbInformation.addedTestsKeyValue.FirstOrDefault(kvp => kvp.Value == (string?)selectedTest);
                dbInformation.tempTestTestHolder.Clear();
                dbInformation.tempTestTestHolder[selectedKvpp.Key] = selectedKvpp.Value;

                dbMethods.insertStateOfHealth(Int32.Parse(maskedTextBox1.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return; 
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
