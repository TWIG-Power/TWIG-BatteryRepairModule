using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Status_Review
{
    public partial class statusReviewForm : Form
    {
        private string[] oems = { "Cobra", "KTM", "Misc", "All" };
        private List<Module> filteredList = new List<Module>(); 
        public statusReviewForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            dbMethods.loadAllTickets();

            foreach (Module module in dbInformation.activeModules)
            {
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - {module.SerialNumber} ({module.ticketStatus})");
            }

            moduleOemFilterDropDown.Items.AddRange(oems);
            partNumberModelFilter.Enabled = false;
        }

        private void viewDetailedReport_Click(object sender, EventArgs e)
        {

        }

        private void moduleOemFilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            partNumberModelFilter.Enabled = true;


            var filteredList = dbInformation.activeModules
                .Where(module => moduleOemFilterDropDown.SelectedItem.ToString() == "All" || module.Oem == moduleOemFilterDropDown.SelectedItem.ToString())
                .OrderBy(module => module.SerialNumber)
                .ToList();

            queryListBox.Items.Clear();

            foreach (var module in filteredList)
            {
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - {module.SerialNumber} ({module.ticketStatus})");
            }
        }

        private void partNumberModelFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
