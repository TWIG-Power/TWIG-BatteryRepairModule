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

namespace BatteryRepairModule.Forms.Quality
{
    public partial class qualityForm1 : Form
    {

        private BrmMainMenuForm parentForm;
        public qualityForm1(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new qualityForm2(parentForm));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
