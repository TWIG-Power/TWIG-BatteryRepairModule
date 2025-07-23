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
        private int showOnlyTicketNum;
        private List<string> tempList = new List<string>(); 
        public BrmTicketCreationForm3(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            this.parentForm = parentRef;

            dbMethods.loadreportTypeOptions();
            foreach (var report in dbInformation.reportTypeKeyPair)
            {
                tempList.Add($"{report.Key} - {report.Value}"); 
            }

            var tempList2 = tempList.OrderBy(s => (s.Split('-')[1]).Trim()).ToArray();

            errorsListBox.Items.AddRange(tempList2.ToArray()); 

            var errorChecks = new Dictionary<string, bool?>
            {
            { "Housing Scraped", BrmTicketCreationForm2.tempCheckHousingScrape },
            { "Evidence Of Tampering", BrmTicketCreationForm2.tempCheckEvidenceOfTamp },
            { "Screws Missing", BrmTicketCreationForm2.tempCheckScrewsMissing },
            { "Housing Dents/Holes", BrmTicketCreationForm2.tempCheckHousingDentsHoles },
            { "Missing Wires", BrmTicketCreationForm2.tempCheckMissingWires },
            { "Charge Port Damage", BrmTicketCreationForm2.tempCheckChargePort },
            { "Cable Damage", BrmTicketCreationForm2.tempCheckCableDamage },
            { "Gore Vent Damage", BrmTicketCreationForm2.tempCheckGoveVent },
            { "Communication Port Damage", BrmTicketCreationForm2.tempCheckCommPort },
            { "Missing Studs", BrmTicketCreationForm2.tempMissingStuds}
            };

            foreach (var error in errorChecks)
            {
                if (error.Value == true)
                {
                    var kvp = dbInformation.reportTypeKeyPair.FirstOrDefault(kvp => kvp.Value == error.Key);
                    if (!string.IsNullOrEmpty(kvp.Value))
                        addedErrorsListBox.Items.Add($"{kvp.Key} - {kvp.Value}");
                }
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair.Add(0, dbMethods.getLastTwigTicketNumber() + 1);
                showOnlyTicketNum = dbInformation.selectedTwigTicketKeyPair.Values.First(); 

                dbInformation.selectedModuleType.Clear(); 
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

                bool cond1 = dbMethods.createDatabaseTicket(dbInformation.selectedTwigTicketKeyPair.Values.First(), dbInformation.selectedStaffKeyValue);
                bool cond2 = dbMethods.insertInitialAssessment();
                bool cond3 = dbMethods.insertCustomerReport();

                if (cond1 && cond2 && cond3)
                {
                    ClearTempValues();
                    MessageBox.Show($"Ticket {showOnlyTicketNum} creation completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    parentForm.OpenChildForm(new BrmTicketCreationForm(parentForm)); 
                    return;
                }
                else
                {
                    MessageBox.Show("Error uploading ticket. Please try again.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The following exception was thrown: {ex}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
