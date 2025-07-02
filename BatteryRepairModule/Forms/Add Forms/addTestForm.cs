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
    public partial class addTestForm : Form
    {
        public addTestForm()
        {
            InitializeComponent();

            dbMethods.getTestingOptions();
            listBox1.Items.AddRange(dbInformation.testingOptionsKeyValue.Select(kvp => kvp.Value).ToArray());

            dbMethods.getAddedTestsByTwigTicket();
            listBox2.Items.AddRange(dbInformation.addedTestsKeyValue.Select(kvp => kvp.Value).ToArray()); 

        }

        private void addSelectedTest_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = listBox1.SelectedItem.ToString();
                var selectedItemKvp = dbInformation.testingOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == selectedItem);
                dbInformation.tempAddNewTest.Clear();
                dbInformation.tempAddNewTest[selectedItemKvp.Key] = selectedItemKvp.Value;

                dbMethods.insertNewTestAction();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
