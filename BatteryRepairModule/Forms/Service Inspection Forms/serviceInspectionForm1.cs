using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteryRepairModule.Forms.BRM;

namespace BatteryRepairModule.Forms.Service_Inspection_Forms
{
    public partial class serviceInspectionForm1 : Form
    {
        private BrmMainMenuForm parentForm;
        public serviceInspectionForm1(BrmMainMenuForm parentRef)
        {

            InitializeComponent();
            this.parentForm = parentRef;
        }

        private void continueButton_Click_1(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new serviceInspectionForm2(parentForm));

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
