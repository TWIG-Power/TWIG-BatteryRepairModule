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
    public partial class BrmRepairActionForm : Form
    {
        public BrmRepairActionForm()
        {
            InitializeComponent();
        }

        private void repairCompletedButton_Click(object sender, EventArgs e)
        {

        }

        private void addRepairActionbutton_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void recycleButton_Click(object sender, EventArgs e)
        {

        }

        private void addRepairActionButton_Click_1(object sender, EventArgs e)
        {
            var newForm = new addRepairActionForm();
            newForm.Show();
        }

        private void repairCompletedButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
