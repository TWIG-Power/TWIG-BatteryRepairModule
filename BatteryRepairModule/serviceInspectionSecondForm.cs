using BatteryRepairModule.Forms.BRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.BRM
{
    public partial class serviceInspectionSecondForm : Form
    {
        private BrmMainMenuForm parentForm;
        public serviceInspectionSecondForm(BrmMainMenuForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void addErrorCodeButton_Click(object sender, EventArgs e)
        {

        }

        private void removeErrorCodeButton_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionThirdForm(parentForm));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionFirstForm(parentForm));
        }

        private void thirtyMinuteDryCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void diagnosticToolCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cleanHousingCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
