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
        public stateOfHealthCalculatorForm()
        {
            InitializeComponent();
            dbMethods.getModuleType();
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

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
