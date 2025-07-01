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
        public addRepairActionForm(ListBox listboxRef, bool authoRepairRef)
        {
            InitializeComponent();
            modifiedListBox = listboxRef;
            this.authoRepair = authoRepairRef; 

            dbMethods.getRepairOptions();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(dbInformation.repairActionOptions.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
        }

        private void addRepairActionForm_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (!modifiedListBox.Items.Contains(listBox1.SelectedItem.ToString()) && authoRepair == false)
                modifiedListBox.Items.Add(listBox1.SelectedItem.ToString()); 

            else if (!modifiedListBox.Items.Contains(listBox1.SelectedItem.ToString()) && authoRepair == true){
                var selectedValue = listBox1.SelectedItem.ToString();
                var str = selectedValue as string;
                if (!string.IsNullOrEmpty(str))
                {
                    var parts = str.Split(new[] { " - " }, 2, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        dbInformation.newRepairActionInRepairFormKeyValue[Int16.Parse(parts[0])] = parts[1];
                    }
                }

                if (!modifiedListBox.Items.Contains(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})")))
                {
                    dbMethods.insertRepairRepairForm();
                    dbMethods.loadRepairActionKeyValueStatus();
                    modifiedListBox.Items.Clear();
                    modifiedListBox.Items.AddRange(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());
                }

            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
