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
            try
            {
                BRMinformation.TWIGCaseNumber = Int32.Parse(twigTicketNumberTextBox.Text);
                BRMinformation.selectedBatteryType = batteryTypeDropDown.SelectedItem.ToString();
                BRMinformation.batterySerialNumber = Int32.Parse(batterySerialNumberTextBox.Text);
                BRMinformation.vehicleVINNumber = vehicleVinNumberTextBox.Text;
                BRMinformation.staffCreatedReport = staffInitiatingReportDropDown.ToString();

                if (BRMinformation.TWIGCaseNumber == 0)
                {
                    MessageBox.Show($"Please fill the TWIG Ticket Number text box in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(BRMinformation.selectedBatteryType))
                {
                    MessageBox.Show($"Please select a module type in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (BRMinformation.batterySerialNumber == 0)
                {
                    MessageBox.Show($"Please fill the module serial number text box in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(BRMinformation.vehicleVINNumber))
                {
                    MessageBox.Show($"Please fill the vehicle vin number in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(BRMinformation.staffCreatedReport))
                {
                    MessageBox.Show($"Please identify yourself in the respective dropdown in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                parentForm.OpenChildForm(new BrmTicketCreationForm2(parentForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The following exception was thrown: {ex}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
