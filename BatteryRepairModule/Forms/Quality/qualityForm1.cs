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
        private string desktopPath;
        private string folderPath;
        private string completedFilePath;
        private string completedFileName; 
        public qualityForm1(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef;
            dbMethods.loadAwaitingQualityStatus();
            twigTicketNumberDropDown.Items.AddRange(
                dbInformation.activeTwigCaseNumbers.Select(kvp =>
                    $"[{kvp.Value}] - {dbInformation.activeModuleSerialNumbers[kvp.Key].ToString()}"
                ).ToArray());

            dbMethods.loadStaffNames();
            staffInitiatingReportDropDown.Items.AddRange(dbInformation.staffKeyPairOptions.Select(kvp => kvp.Value.ToString()).ToArray());

            staffInitiatingReportDropDown.Enabled = false;
            attachFileButton.Enabled = false;

            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            folderPath = Path.Combine(desktopPath, "BRM Quality Checklists");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (twigTicketNumberDropDown.SelectedItem != null)
            {
                staffInitiatingReportDropDown.Enabled = true;

                var selectedValue = twigTicketNumberDropDown.SelectedItem.ToString();
                var converted = selectedValue.Split('[')[1].Split(']')[0]; 
                var selectedKvp = dbInformation.activeTwigCaseNumbers.FirstOrDefault(kvp => kvp.Value.ToString() == converted);
                dbInformation.selectedTwigTicketKeyPair.Clear();
                dbInformation.selectedTwigTicketKeyPair[selectedKvp.Key] = selectedKvp.Value;

                dbMethods.getModuleType();
                dbMethods.getLatestChecklistVersion();

                string fileName = $"QualityChecklist_{converted}.pdf";
                string filePath = Path.Combine(folderPath, fileName);

                if (File.Exists(filePath))
                {
                    var result = MessageBox.Show("File already exists. Would you like to replace?", "Warning: File Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        File.WriteAllBytes(filePath, dbInformation.downloadedFileBytes);
                    }
                }
                else
                {
                    File.WriteAllBytes(filePath, dbInformation.downloadedFileBytes);
                }

                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void staffInitiatingReportDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staffInitiatingReportDropDown.SelectedItem != null)
            {
                attachFileButton.Enabled = true;

                string selectedItem = staffInitiatingReportDropDown.SelectedItem as string;
                var selectedKvp = dbInformation.staffKeyPairOptions.FirstOrDefault(kvp => kvp.Value == selectedItem);
                dbInformation.selectedStaffKeyValue.Clear();
                dbInformation.selectedStaffKeyValue[selectedKvp.Key] = selectedKvp.Value; 
            }
        }

        private void attachFileButton_Click(object sender, EventArgs e)
        {
            completedFilePath = string.Empty; 
            completedFilePath = Path.Combine(folderPath, $"QualityChecklist_{dbInformation.selectedTwigTicketKeyPair.Values.First()}.pdf");

            if (!File.Exists(completedFilePath))
            {
                MessageBox.Show("File was not found automatically. Please attach.", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            completedFileName = Path.GetFileName(completedFilePath);
            qualityChecklistPathTextBox.Text = completedFileName; 

        }

        private void continueButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(qualityChecklistPathTextBox.Text) && !string.IsNullOrEmpty(completedFilePath))
            {
                byte[] convertedFile = File.ReadAllBytes(completedFilePath);
                bool result = dbMethods.uploadCompletedQualityChecklist(convertedFile);
                if (result)
                {
                    MessageBox.Show("Quality checklist uploaded successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbMethods.clearModuleForShipping(); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to upload the quality checklist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void addNewChecklist_Click(object sender, EventArgs e)
        {
            using (var newForm = new updateLatestChecklistForm())
                    newForm.ShowDialog(this);
        }
    }
}
