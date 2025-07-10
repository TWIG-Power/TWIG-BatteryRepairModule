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
    public partial class addRepairActionForm : Form
    {
        private ListBox modifiedListBox;
        private bool authoRepair;
        private bool recycled = false; 
        public addRepairActionForm(ListBox listboxRef, bool authoRepairRef)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            modifiedListBox = listboxRef;
            this.authoRepair = authoRepairRef;

            dbMethods.getRepairOptions();
            listBox1.Items.Clear();
            string[] temp = dbInformation.repairActionOptions.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray();
            Array.Sort(temp);
            listBox1.Items.AddRange(temp);
        }

        private void addRepairActionForm_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modifiedListBox.Items.Contains(listBox1.SelectedItem.ToString()) && authoRepair == false)
                    modifiedListBox.Items.Add(listBox1.SelectedItem.ToString()); 

                else if (!modifiedListBox.Items.Contains(listBox1.SelectedItem.ToString()) && authoRepair == true){

                    string temp = listBox1.SelectedItem.ToString().Split(" - ")[1];
                    if (dbInformation.clearedRepairsValueStatusPair.ContainsKey(temp))
                        return; 

                    var selectedValue = listBox1.SelectedItem.ToString();
                    var str = selectedValue as string;
                    if (!string.IsNullOrEmpty(str))
                    {
                        var parts = str.Split(new[] { " - " }, 2, StringSplitOptions.None);
                        if (parts.Length == 2)
                        {
                            dbInformation.newRepairActionInRepairFormKeyValue[Int16.Parse(parts[0])] = parts[1];
                            if (parts[1] == "RECYCLE")
                            {
                                var recycleResult = MessageBox.Show("Are you sure you want to authorize recycling for this item?", "Confirm Recycle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (recycleResult == DialogResult.No)
                                {
                                    return;
                                }
                                else if (recycleResult == DialogResult.Yes)
                                {
                                    dbMethods.recycleStatus();
                                    this.Close();
                                    recycled = true; 
                                }
                            }
                        }
                    }

                    if (!modifiedListBox.Items.Contains(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})")) && !recycled)
                    {
                        dbMethods.insertRepairRepairForm();
                        dbMethods.loadRepairActionKeyValueStatus();
                        modifiedListBox.Items.Clear();
                        modifiedListBox.Items.AddRange(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());
                    }

                }
                if (!recycled)
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
    }
}
