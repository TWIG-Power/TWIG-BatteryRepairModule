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
        // Temporary variables for form data
        public static string? tempVerifyShippingChoice;
        public static bool? tempBatteryLeadsProtected;
        public static bool? tempCheckHousingScrape;
        public static bool? tempCheckEvidenceOfTamp;
        public static bool? tempCheckScrewsMissing;
        public static bool? tempCheckHousingDentsHoles;
        public static bool? tempCheckMissingWires;
        public static bool? tempCheckChargePort;
        public static bool? tempCheckCableDamage;
        public static bool? tempCheckGoveVent;
        public static bool? tempCheckCommPort;

        private BrmMainMenuForm parentForm;
        public BrmTicketCreationForm2(BrmMainMenuForm parent)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            this.parentForm = parent;

            // Load temp variables back into form controls
            LoadTempVariables();
        }

        private void LoadTempVariables()
        {
            try
            {
                if (!string.IsNullOrEmpty(tempVerifyShippingChoice))
                {
                    switch (tempVerifyShippingChoice)
                    {
                        case "Safe":
                            safeShippingButton.Checked = true;
                            break;
                        case "Unsafe":
                            unsafeShippingButton.Checked = true;
                            break;
                        case "N/A":
                            doesNotApplyShippingButton.Checked = true;
                            break; 
                        default:
                            break;
                    }
                }

                if (tempBatteryLeadsProtected.HasValue)
                {
                    if (tempBatteryLeadsProtected.Value)
                        battLeadProtectYes.Checked = true;
                    else
                        battLeadProtectNo.Checked = true;
                }

                if (tempCheckHousingScrape.HasValue)
                    housingScrapesCheckBox.Checked = tempCheckHousingScrape.Value;
                if (tempCheckEvidenceOfTamp.HasValue)
                    evidenceOfTamperingCheckBox.Checked = tempCheckEvidenceOfTamp.Value;
                if (tempCheckScrewsMissing.HasValue)
                    screwsMissingCheckBox.Checked = tempCheckScrewsMissing.Value;
                if (tempCheckHousingDentsHoles.HasValue)
                    housingDentsCheckBox.Checked = tempCheckHousingDentsHoles.Value;
                if (tempCheckMissingWires.HasValue)
                    missingWiresCheckBox.Checked = tempCheckMissingWires.Value;
                if (tempCheckChargePort.HasValue)
                    chargePortCheckBox.Checked = tempCheckChargePort.Value;
                if (tempCheckCableDamage.HasValue)
                    cableDamageCheckBox.Checked = tempCheckCableDamage.Value;
                if (tempCheckGoveVent.HasValue)
                    goveVentCheckBox.Checked = tempCheckGoveVent.Value;
                if (tempCheckCommPort.HasValue)
                    commPortCheckBox.Checked = tempCheckCommPort.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading temporary variables: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                tempVerifyShippingChoice = safeShippingButton.Checked ? "Safe" : (unsafeShippingButton.Checked ? "Unsafe" : "N/A");
                tempBatteryLeadsProtected = battLeadProtectYes.Checked ? true : (battLeadProtectNo.Checked ? false : null);
                
                tempCheckHousingScrape = housingScrapesCheckBox.Checked;
                tempCheckEvidenceOfTamp = evidenceOfTamperingCheckBox.Checked;
                tempCheckScrewsMissing = screwsMissingCheckBox.Checked;
                tempCheckHousingDentsHoles = housingDentsCheckBox.Checked;
                tempCheckMissingWires = missingWiresCheckBox.Checked;
                tempCheckChargePort = chargePortCheckBox.Checked;
                tempCheckCableDamage = cableDamageCheckBox.Checked;
                tempCheckGoveVent = goveVentCheckBox.Checked;
                tempCheckCommPort = commPortCheckBox.Checked;

                if (string.IsNullOrEmpty(tempVerifyShippingChoice))
                {
                    MessageBox.Show("Please select an option regarding shipping verification", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tempBatteryLeadsProtected == null)
                {
                    MessageBox.Show("Please select an option regarding battery leads protection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                
                parentForm.OpenChildForm(new BrmTicketCreationForm3(parentForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The following exception was thrown: {ex}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                parentForm.OpenChildForm(new BrmTicketCreationForm(parentForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while cancelling: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
