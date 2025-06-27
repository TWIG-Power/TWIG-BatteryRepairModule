using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.BRM
{
    public partial class BrmTicketCreationForm : Form
    {
        public static int tempTwigCaseNum; 
        public static string? tempBattType;
        public static int? tempSerialNum;
        public static string? tempVinNum;
        public static string? tempStaffCreateReport;
        private BrmMainMenuForm parentForm;
        public BrmTicketCreationForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;

            // Load staff names
            dbMethods.loadStaffNames();
            staffInitiatingReportDropDown.Items.AddRange(dbInformation.staffOptions.ToArray());

            // Load new ticket number
            dbInformation.TWIGCaseNumber = dbMethods.getLastTwigTicketNumber() + 1;
            twigTicketNumberTextBox.Text = dbInformation.TWIGCaseNumber.ToString();
            twigTicketNumberTextBox.Enabled = false; 

            // MODIFY Load module options
            batteryTypeDropDown.Items.AddRange(dbInformation.staffOptions.ToArray());

            LoadTempVariables();
        }

        private void LoadTempVariables()
        {
            if ( tempTwigCaseNum != 0)
                twigTicketNumberTextBox.Text = tempTwigCaseNum.ToString();

            if (!string.IsNullOrEmpty(tempBattType))
                batteryTypeDropDown.SelectedItem = tempBattType;

            if (tempSerialNum.HasValue && tempSerialNum != 0)
                batterySerialNumberTextBox.Text = tempSerialNum.ToString();

            if (!string.IsNullOrEmpty(tempVinNum))
                vehicleVinNumberTextBox.Text = tempVinNum;

            if (!string.IsNullOrEmpty(tempStaffCreateReport))
                staffInitiatingReportDropDown.SelectedItem = tempStaffCreateReport;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                tempTwigCaseNum = Int32.Parse(twigTicketNumberTextBox.Text);

                //dbInformation.TWIGTicketOptions.Add(dbInformation.TWIGCaseNumber.ToString()); 

                tempBattType = batteryTypeDropDown.SelectedItem.ToString();
                tempSerialNum = Int32.Parse(batterySerialNumberTextBox.Text);
                tempVinNum = vehicleVinNumberTextBox.Text;
                tempStaffCreateReport = staffInitiatingReportDropDown.SelectedItem.ToString();

                if (tempTwigCaseNum == 0)
                {
                    MessageBox.Show($"Please fill the TWIG Ticket Number text box in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(tempBattType))
                {
                    MessageBox.Show($"Please select a module type in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tempSerialNum == 0)
                {
                    MessageBox.Show($"Please fill the module serial number text box in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(tempVinNum))
                {
                    MessageBox.Show($"Please fill the vehicle vin number in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(tempStaffCreateReport))
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
            dbInformation.ClearTicketCreation(); 
            this.Close();
        }
        
    }
}
