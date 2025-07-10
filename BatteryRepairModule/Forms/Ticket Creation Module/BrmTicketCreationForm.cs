using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.BRM
{
    public partial class BrmTicketCreationForm : Form
    {
        public static int tempTwigCaseNum;
        public static int? tempSerialNum;
        public static string? tempVinNum;
        private BrmMainMenuForm parentForm;
        public static List<int> keys = new List<int>();
        public static List<int> table = new List<int>();
        public static List<int> staffKeys = new List<int>();
        public static Dictionary<int, Dictionary<int, string>> tempSelectedMod = new Dictionary<int, Dictionary<int, string>>();
        public static Dictionary<int, string> tempSelectedStaff = new Dictionary<int, string>();
        public BrmTicketCreationForm(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            this.parentForm = parentRef;

            try
            {
                dbMethods.loadStaffNames();
                staffInitiatingReportDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Values.ToArray());

                dbInformation.TWIGCaseNumber = dbMethods.getLastTwigTicketNumber() + 1;
                twigTicketNumberTextBox.Text = dbInformation.TWIGCaseNumber.ToString();
                twigTicketNumberTextBox.Enabled = false;

                dbMethods.loadAllModuleTypes();
                batteryTypeDropDown.Items.Clear();
                foreach (var keyPair in dbInformation.moduleTypesByOEM)
                {
                    table.Add(keyPair.Key);
                    foreach (var intKeyPair in keyPair.Value)
                    {
                        keys.Add(intKeyPair.Key);
                        batteryTypeDropDown.Items.Add(intKeyPair.Value);
                    }
                }

                LoadTempVariables();

                tempSelectedMod.Clear();
                tempSelectedStaff.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTempVariables()
        {
            if (tempTwigCaseNum != 0)
                twigTicketNumberTextBox.Text = tempTwigCaseNum.ToString();

            if (tempSerialNum.HasValue && tempSerialNum != 0)
                batterySerialNumberTextBox.Text = tempSerialNum.ToString();

            if (!string.IsNullOrEmpty(tempVinNum))
                vehicleVinNumberTextBox.Text = tempVinNum;

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                tempTwigCaseNum = Int32.Parse(twigTicketNumberTextBox.Text);

                if (batteryTypeDropDown.SelectedItem == null ||
                    !batteryTypeDropDown.Items.Contains(batteryTypeDropDown.Text))
                {
                    MessageBox.Show($"Please select a valid module type from the dropdown in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var keyPair in dbInformation.moduleTypesByOEM)
                {
                    foreach (var intKeyPair in keyPair.Value)
                    {
                        if (batteryTypeDropDown.SelectedItem.ToString() == intKeyPair.Value)
                        {
                            dbInformation.selectedModuleType.Clear();
                            tempSelectedMod.Clear();
                            tempSelectedMod.Add(keyPair.Key, new Dictionary<int, string> { { intKeyPair.Key, intKeyPair.Value } });
                        }
                    }
                }

                tempSerialNum = Int32.Parse(batterySerialNumberTextBox.Text);
                tempVinNum = vehicleVinNumberTextBox.Text;

                if (staffInitiatingReportDropDown.SelectedItem != null)
                {
                    var selectedValue = staffInitiatingReportDropDown.SelectedItem.ToString();
                    var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value.ToString() == selectedValue);
                    tempSelectedStaff.Clear();
                    tempSelectedStaff[selectedKvp.Key] = selectedKvp.Value;
                }

                if (tempTwigCaseNum == 0)
                {
                    MessageBox.Show($"Please fill the TWIG Ticket Number text box in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!dbInformation.moduleTypesByOEM.Any())
                {
                    MessageBox.Show($"Please select a module type in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tempSerialNum == 0)
                {
                    MessageBox.Show($"Please fill the module serial number text box in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tempVinNum))
                {
                    var result = MessageBox.Show(
                    "No VIN number was entered. Do you want to continue without a VIN number?", "VIN Number Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        tempVinNum = null;
                    }
                }
                if (!tempSelectedStaff.Any())
                {
                    MessageBox.Show($"Please identify yourself in the respective dropdown in order to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dbMethods.checkIfSerialNumberHasActiveTicket(tempSerialNum))
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
