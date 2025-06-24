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
    public partial class BrmTicketCreationForm2 : Form
    {

        private BrmMainMenuForm parentForm;
        public BrmTicketCreationForm2(BrmMainMenuForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new BrmTicketCreationForm3(parentForm));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new BrmTicketCreationForm(parentForm)); 
        }
    }
}
