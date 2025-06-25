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
            try
            {
                shippingCheck();

                batteryCheck();

                BRMinformation.batteryLeadsProtected = battLeadProtectYes.Checked ? true : false;

                if (string.IsNullOrEmpty(BRMinformation.verifyShippingChoice))
                {
                    MessageBox.Show("Please select an option regarding shipping verification", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BRMinformation.batteryLeadsProtected == null)
                {
                    MessageBox.Show("Please select an option regarding battery leads protection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                parentForm.OpenChildForm(new BrmTicketCreationForm3(parentForm));
            }
            catch (Exception ex)
            {

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new BrmTicketCreationForm(parentForm));
        }

        private void shippingCheck()
        {
            if (safeShippingButton.Checked == true)
                BRMinformation.verifyShippingChoice = "Safe";
            else if (unsafeShippingButton.Checked == true)
                BRMinformation.verifyShippingChoice = "Unsafe";
            else
                BRMinformation.verifyShippingChoice = "N/A";
        }

        private void batteryCheck()
        {
            if (housingScrapesCheckBox.Checked)
                BRMinformation.checkHousingScrape = true;
            if (evidenceOfTamperingCheckBox.Checked)
                BRMinformation.checkEvidenceOfTamp = true;
            if (screwsMissingCheckBox.Checked)
                BRMinformation.checkScrewsMissing = true;
            if (housingDentsCheckBox.Checked)
                BRMinformation.checkHousingDentsHoles = true;
            if (missingWiresCheckBox.Checked)
                BRMinformation.checkMissingWires = true;
            if (chargePortCheckBox.Checked)
                BRMinformation.checkChargePort = true;
            if (cableDamageCheckBox.Checked)
                BRMinformation.checkCableDamage = true;
            if (goveVentCheckBox.Checked)
                BRMinformation.checkGoveVent = true;
            if (commPortCheckBox.Checked)
                BRMinformation.checkCommPort = true;
        }
    }
}
