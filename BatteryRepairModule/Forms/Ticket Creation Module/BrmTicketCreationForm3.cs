using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
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
            try
            {
                var errorsArray = addedErrorsListBox.Items.Cast<string>().ToList();
                BRMinformation.moduleReportedErrors.AddRange(errorsArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The following exception was thrown: {ex}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new BrmTicketCreationForm2(parentForm));
        }

        private void addCustomerReportButton_Click(object sender, EventArgs e)
        {
            addedErrorsListBox.Items.Add(errorsListBox.SelectedItem); 
        }

        private void removeCustomerReportButton_Click(object sender, EventArgs e)
        {
            if (addedErrorsListBox.SelectedItem != null)
            {
            addedErrorsListBox.Items.Remove(addedErrorsListBox.SelectedItem);
            }
        }
    }
}
