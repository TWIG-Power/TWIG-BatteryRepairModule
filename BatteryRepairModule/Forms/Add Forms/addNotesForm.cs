using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Add_Forms
{
    public partial class addNotesForm : Form
    {
        private bool viewOnly;
        private ListBox referenceListBox;
        public addNotesForm(ListBox passedListBox, bool viewOnlyRef)
        {
            InitializeComponent();
            this.viewOnly = viewOnlyRef;
            this.referenceListBox = passedListBox;

            if (viewOnly)
            {
                var selectedValue = referenceListBox.SelectedItem as string;
                if (!string.IsNullOrEmpty(selectedValue))
                {
                    var selectedRepaired = selectedValue.Split('(')[0].Trim();
                    var selectedKvp = dbInformation.clearedRepairsKeyValPair.FirstOrDefault(kvp => kvp.Value.ToString() == selectedRepaired);

                    if (selectedKvp.Key != 0) // Ensure a valid key is found
                    {
                        dbInformation.tempUpdateNotesRepairHolder.Clear();
                        dbInformation.tempUpdateNotesRepairHolder[selectedKvp.Key] = selectedKvp.Value;

                        dbInformation.repairNotes = string.Empty;
                        dbMethods.getNotes();

                        richTextBox1.Enabled = false;
                        richTextBox1.Text = dbInformation.repairNotes;
                    }
                    else
                    {
                        MessageBox.Show("Selected repair not found in the dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No repair selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (viewOnly)
            {
                this.Close();
            }
            else
            {
                var selectedValue = referenceListBox.SelectedItem as string;
                var selectedRepaired = selectedValue?.Split('(')[0].Trim();
                var selectedKvp = dbInformation.clearedRepairsKeyValPair.FirstOrDefault(kvp => kvp.Value.ToString() == selectedRepaired);
                dbInformation.tempUpdateNotesRepairHolder[selectedKvp.Key] = selectedKvp.Value; 

                dbInformation.repairNotes = richTextBox1.Text.ToString();

                dbMethods.updateNotes(); 
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
