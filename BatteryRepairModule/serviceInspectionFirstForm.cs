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
    public partial class serviceInspectionFirstForm : Form
    {

        private BrmMainMenuForm parentForm;
        public serviceInspectionFirstForm(BrmMainMenuForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionSecondForm(parentForm));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
