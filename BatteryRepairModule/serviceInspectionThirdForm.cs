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
    public partial class serviceInspectionThirdForm : Form
    {

        private BrmMainMenuForm parentForm;
        public serviceInspectionThirdForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;
        }

        private void chargePortCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cableDamageCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void goveVentCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void communicationPortCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionFourthForm(parentForm));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionSecondForm(parentForm));
        }
    }
}
