using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteryRepairModule.Forms.Add_Repair_Action_Form;
using BatteryRepairModule.Forms.BRM;

namespace BatteryRepairModule
{
    public partial class BrmTicketCreationForm3 : Form
    {
        private BrmMainMenuForm parentForm;
        public BrmTicketCreationForm3(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new BrmTicketCreationForm2(parentForm));
        }

        private void addCustomerReportButton_Click(object sender, EventArgs e)
        {

        }

        private void removeCustomerReportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
