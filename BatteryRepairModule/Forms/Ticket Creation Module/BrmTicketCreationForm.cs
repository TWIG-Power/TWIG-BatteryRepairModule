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
    public partial class BrmTicketCreationForm : Form
    {
        private BrmMainMenuForm parentForm;
        public BrmTicketCreationForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef; 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new BrmTicketCreationForm2(parentForm)); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
