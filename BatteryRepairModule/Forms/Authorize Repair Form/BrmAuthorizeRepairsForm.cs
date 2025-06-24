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
    public partial class BrmAuthorizeRepairsForm : Form
    {
        public BrmAuthorizeRepairsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {

        }

        private void addAuthorizedRepairAction_Click(object sender, EventArgs e)
        {
            using (var neForm = new addRepairActionForm(authorizedRepairsListBox))
            {
                neForm.ShowDialog(this);
            }
        }

        private void removeAuthorizedRepairAction_Click(object sender, EventArgs e)
        {

        }
    }
}
