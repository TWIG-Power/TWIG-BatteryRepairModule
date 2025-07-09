using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Add_Forms
{
    public partial class updateLatestChecklistForm : Form
    {
        private byte[]? fileData;
        private string fileName; 

        public updateLatestChecklistForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            attachFileButton.Enabled = false;

            twigTicketNumberDropDown.Items.Clear();
            dbMethods.loadAllModuleTypes();
            foreach (var kvp in dbInformation.moduleTypesByOEM)
            {
                foreach (var kvp2 in dbInformation.moduleTypesByOEM[kvp.Key])
                {
                    string oemName = kvp.Key switch
                    {
                        0 => "cobra",
                        1 => "ktm",
                        2 => "misc",
                        _ => kvp.Key.ToString()
                    };
                    twigTicketNumberDropDown.Items.Add($"{oemName} - {kvp2.Value}");
                }
            }
        }

        private void twigTicketNumberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbInformation.selectedOemModelKeyPair.Clear(); 
            attachFileButton.Enabled = true;

            var selectedItem = twigTicketNumberDropDown.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                var parts = selectedItem.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    string manufacturer = parts[0].Trim();
                    string moduleType = parts[1].Trim();
                    switch (manufacturer)
                    {
                        case "cobra":
                            int match = dbInformation.moduleTypesByOEM[0].FirstOrDefault(kvp => kvp.Value == moduleType).Key;
                            dbInformation.selectedOemModelKeyPair.Add(manufacturer, match);
                            break;
                        case "ktm":
                            int match2 = dbInformation.moduleTypesByOEM[1].FirstOrDefault(kvp => kvp.Value == moduleType).Key;
                            dbInformation.selectedOemModelKeyPair.Add(manufacturer, match2);
                            break;
                        case "misc":
                            int match3 = dbInformation.moduleTypesByOEM[0].FirstOrDefault(kvp => kvp.Value == moduleType).Key;
                            dbInformation.selectedOemModelKeyPair.Add(manufacturer, match3);
                            break;
                        default:
                            MessageBox.Show("ERROR!");
                            break;
                    }
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (fileData == null || fileData.Length == 0)
            {
                MessageBox.Show("Please upload a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int updated = dbMethods.updateLatestChecklistForm(fileData, fileName);
                dbMethods.updateOemChecklist(updated); 
                MessageBox.Show("File saved to database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void attachFileButton_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
            filePath = openFileDialog.FileName;
            fileName = Path.GetFileName(filePath);
            fileData = File.ReadAllBytes(filePath);
            }
            qualityChecklistPathTextBox.Text = fileName;
        }
    }
}
