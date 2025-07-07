using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteryRepairModule.Forms.Add_Forms;
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
            dbMethods.loadAwaitingQualityStatus();
            twigTicketNumberDropDown.Items.AddRange(dbInformation.activeTwigCaseNumbers.Select(kvp => kvp.Value.ToString()).ToArray());

            dbMethods.loadStaffNames();
            staffInitiatingReportDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Select(kvp => kvp.Value.ToString()).ToArray());

            staffInitiatingReportDropDown.Enabled = false;
            attachFileButton.Enabled = false;
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (twigTicketNumberDropDown.SelectedItem != null)
                staffInitiatingReportDropDown.Enabled = true;
        }

        private void staffInitiatingReportDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staffInitiatingReportDropDown.SelectedItem != null)
                attachFileButton.Enabled = true;
        }

        private void attachFileButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbInformation.qualityFilePath = openFileDialog.FileName;
                }
                qualityChecklistPathTextBox.Text = dbInformation.qualityFilePath;
            }
        }

        private void continueButton_Click_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {

        }

        private void addNewChecklist_Click(object sender, EventArgs e)
        {
            using (var newForm = new updateLatestChecklistForm())
                    newForm.ShowDialog(this);
        }
    }
}
