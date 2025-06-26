using BatteryRepairModule.Forms.Add_Forms;
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

        private void continueButton_Click_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void addRepairActionButton_Click_2(object sender, EventArgs e)
        {
            using (var newForm = new addRepairActionForm(repairActionsListBox))
            {
                newForm.ShowDialog(this);
            }
        }

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            using (var newForm = new addStatusUpdateForm())
            {
                newForm.ShowDialog(this);
            }
        }
    }
}
