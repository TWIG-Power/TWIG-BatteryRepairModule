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
    public partial class activateDeactivateRepairForm : Form
    {
        public activateDeactivateRepairForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            dbMethods.getRepairOptionsEnabledDisabled(); 
            foreach (repairOption repair in dbInformation.repairOptionsList)
            {
                string status = repair.Enabled ? "Enabled" : "Disabled";
                listBox1.Items.Add($"[{repair.Id}] {repair.Description} - ({status})");
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            int parsedSelectedItem = Int32.Parse(selectedItem.Split('[')[1].Split(']')[0]);
            string currentStatus = selectedItem.Split('(')[1].Split(')')[0];

            bool isEnabled = currentStatus.Equals("Enabled");

            dbMethods.updateRepairEnabledDisabled(parsedSelectedItem, !isEnabled);
            this.Close(); 

        }
    }
}
