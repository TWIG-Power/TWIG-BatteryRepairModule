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
    public partial class serviceInspectionFourthForm : Form
    {

        private BrmMainMenuForm parentForm;
        public serviceInspectionFourthForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;
        }

        private void attachButton_Click(object sender, EventArgs e)
        {

        }

        private void addRepairActionButton_Click(object sender, EventArgs e)
        {

        }

        private void removeRepairActionButton_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionThirdForm(parentForm));
        }

        private void continueButton_Click_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
