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
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - ({module.SerialNumber}) - {module.stateOfHealth} - {module.ticketStatus}");
            }

            moduleOemFilterDropDown.Items.AddRange(oems);
            partNumberModelFilter.Enabled = false;
        }

        private void viewDetailedReport_Click(object sender, EventArgs e)
        {
            if (queryListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket.", "No Ticket Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTicket = Int32.Parse(queryListBox.SelectedItem.ToString().Split('[')[1].Split(']')[0]);
            int selectedModule = dbInformation.activeModules.FirstOrDefault(m => m.ticketId == selectedTicket).ticketSurrogateKey; 

            initialAssesment test = dbMethods.getCompletedInitialAssesment(selectedModule);
            serviceInspection test2 = dbMethods.getCompletedServiceInspection(selectedModule);
            List<RepairAction> test3 = dbMethods.getCompletedRepairActions(selectedModule);
            List<CustomerReport> test4 = dbMethods.GetCustomerReports(selectedModule);
            List<testAction> test5 = dbMethods.GetCompletedTests(selectedModule); 
            

            MessageBox.Show($"{test2.id} // {test2.staff}");

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
                queryListBox.Items.Add($"[{module.ticketId}] - {module.model} - ({module.SerialNumber}) - {module.stateOfHealth} - {module.ticketStatus}");
            }
        }

        private void partNumberModelFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void getTicketInformation()
        {
        }
    }
}

