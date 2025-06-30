using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Ticket_Creation_Module
{
    public partial class addCustomerReport : Form
    {
        private ListBox listBoxRef;
        public addCustomerReport(ListBox list)
        {
            InitializeComponent();
            this.listBoxRef = list; 
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            bool success; 
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    success = dbMethods.insertNewReportOption(textBox1.Text);
                    if (success)
                    {
                        MessageBox.Show("Option added successfully", "Successfull Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbMethods.loadreportTypeOptions();
                        listBoxRef.Items.Clear(); 
                        listBoxRef.Items.AddRange(dbInformation.reportTypeKeyPair.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Option was not added. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
