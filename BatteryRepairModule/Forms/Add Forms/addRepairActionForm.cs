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
        public addRepairActionForm(ListBox listboxRef)
        {
            InitializeComponent();
            modifiedListBox = listboxRef;

            dbMethods.getRepairOptions();
            listBox1.Items.Clear(); 
            listBox1.Items.AddRange(dbInformation.repairActionOptions.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
        }

        private void addRepairActionForm_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (!modifiedListBox.Items.Contains(listBox1.SelectedItem.ToString()))
                modifiedListBox.Items.Add(listBox1.SelectedItem.ToString()); 
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
