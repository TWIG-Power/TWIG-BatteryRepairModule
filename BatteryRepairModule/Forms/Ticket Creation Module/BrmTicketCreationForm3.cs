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
using BatteryRepairModule.Forms.BRM;
using BatteryRepairModule.Forms.Ticket_Creation_Module;

namespace BatteryRepairModule
{
    public partial class BrmTicketCreationForm3 : Form
    {
        private BrmMainMenuForm parentForm;
        public BrmTicketCreationForm3(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;

            // FOR TESTING PURPOSES ONLY 
            dbMethods.loadreportTypeOptions();
            errorsListBox.Items.AddRange(dbInformation.reportTypeKeyPair.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                dbInformation.selectedTwigTicketKeyPair.Add(0, BrmTicketCreationForm.tempTwigCaseNum);

                dbInformation.selectedModuleType.Add(
                    BrmTicketCreationForm.tempSelectedMod.Keys.First(),
                    BrmTicketCreationForm.tempSelectedMod.Values.First()
                );

                dbInformation.batterySerialNumber = BrmTicketCreationForm.tempSerialNum;
                dbInformation.vehicleVINNumber = BrmTicketCreationForm.tempVinNum;
                dbInformation.selectedStaffKeyValue = BrmTicketCreationForm.tempSelectedStaff;

                dbInformation.verifyShippingChoice = BrmTicketCreationForm2.tempVerifyShippingChoice;
                dbInformation.batteryLeadsProtected = BrmTicketCreationForm2.tempBatteryLeadsProtected;
                dbInformation.checkHousingScrape = BrmTicketCreationForm2.tempCheckHousingScrape;
                dbInformation.checkEvidenceOfTamp = BrmTicketCreationForm2.tempCheckEvidenceOfTamp;
                dbInformation.checkScrewsMissing = BrmTicketCreationForm2.tempCheckScrewsMissing;
                dbInformation.checkHousingDentsHoles = BrmTicketCreationForm2.tempCheckHousingDentsHoles;
                dbInformation.checkMissingWires = BrmTicketCreationForm2.tempCheckMissingWires;
                dbInformation.checkChargePort = BrmTicketCreationForm2.tempCheckChargePort;
                dbInformation.checkCableDamage = BrmTicketCreationForm2.tempCheckCableDamage;
                dbInformation.checkGoveVent = BrmTicketCreationForm2.tempCheckGoveVent;
                dbInformation.checkCommPort = BrmTicketCreationForm2.tempCheckCommPort;

                foreach (var item in addedErrorsListBox.Items)
                {
                    var str = item as string;
                    if (!string.IsNullOrEmpty(str))
                    {
                        var parts = str.Split(new[] { " - " }, 2, StringSplitOptions.None);
                        if (parts.Length == 2)
                        {
                            dbInformation.moduleReportedErrorsKeyPair[Int16.Parse(parts[0])] = parts[1];
                        }
                    }
                }

                dbMethods.createDatabaseTicket(dbInformation.selectedStaffKeyValue);
                dbMethods.insertInitialAssessment();
                dbMethods.insertCustomerReport();

                ClearTempValues(); 
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
            if (errorsListBox.SelectedItem != null)
            {
                if (!addedErrorsListBox.Items.Contains(errorsListBox.SelectedItem))
                    addedErrorsListBox.Items.Add(errorsListBox.SelectedItem);
            }
        }

        private void removeCustomerReportButton_Click(object sender, EventArgs e)
        {
            if (addedErrorsListBox.SelectedItem != null)
            {
                addedErrorsListBox.Items.Remove(addedErrorsListBox.SelectedItem);
            }
        }

        private void addReportOption_Click(object sender, EventArgs e)
        {
            var newform = new addCustomerReport(errorsListBox);
            newform.ShowDialog(this);
        }

        public static void ClearTempValues()
        {
            dbInformation.selectedTwigTicketKeyPair.Clear();
            BrmTicketCreationForm.tempTwigCaseNum = 0;
            BrmTicketCreationForm.tempSerialNum = null;
            BrmTicketCreationForm.tempVinNum = null;
            BrmTicketCreationForm.tempSelectedStaff.Clear();
            BrmTicketCreationForm.keys.Clear();
            BrmTicketCreationForm.table.Clear();
            BrmTicketCreationForm.tempSelectedMod.Clear();
            
            BrmTicketCreationForm2.tempVerifyShippingChoice = null;
            BrmTicketCreationForm2.tempBatteryLeadsProtected = null;
            BrmTicketCreationForm2.tempCheckHousingScrape = null;
            BrmTicketCreationForm2.tempCheckEvidenceOfTamp = null;
            BrmTicketCreationForm2.tempCheckScrewsMissing = null;
            BrmTicketCreationForm2.tempCheckHousingDentsHoles = null;
            BrmTicketCreationForm2.tempCheckMissingWires = null;
            BrmTicketCreationForm2.tempCheckChargePort = null;
            BrmTicketCreationForm2.tempCheckCableDamage = null;
            BrmTicketCreationForm2.tempCheckGoveVent = null;
            BrmTicketCreationForm2.tempCheckCommPort = null;
        }
    }
}
