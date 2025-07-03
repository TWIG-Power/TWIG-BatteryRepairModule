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
    public partial class addStatusUpdateForm : Form
    {
        private string statusType;
        private ListBox modifiedListBox; 
        public addStatusUpdateForm(ListBox listBoxRef, string typeRef)
        {
            InitializeComponent();
            this.modifiedListBox = listBoxRef; 
            this.statusType = typeRef;

            switch (statusType)
            {
                case "Repair":
                    dbMethods.loadRepairStatusOptions();
                    listBox1.Items.AddRange(dbInformation.repairStatusOptionKeyValue.Select(kvp => $"{kvp.Value}").ToArray()); 
                    break;
                case "Issue":
                    dbMethods.loadIssueStatusOptions();
                    listBox1.Items.AddRange(dbInformation.issueStatusOptionsKeyValue.Select(kvp => $"{kvp.Value}").ToArray()); 
                    break;
                case "Test":
                    dbMethods.getTestStatusOptions();
                    listBox1.Items.AddRange(dbInformation.testStatusOptionsKeyValue.Select(kvp => $"{kvp.Value}").ToArray());
                    break;
                default:
                    break;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            switch (statusType)
            {
                case "Repair":
                    if (listBox1.SelectedItem != null)
                    {

                        var selectedRepair = modifiedListBox.SelectedItem as string;
                        var selectedRepaired = selectedRepair?.Split('(')[0].Trim();
                        var selectedKvpp = dbInformation.clearedRepairsKeyValPair.FirstOrDefault(kvp => kvp.Value == (string?)selectedRepaired);
                        dbInformation.tempUpdateRepairRepairHolder.Clear();
                        dbInformation.tempUpdateRepairRepairHolder[selectedKvpp.Key] = selectedKvpp.Value;

                        var selectedStatus2 = listBox1.SelectedItem as string;
                        var selectedKvp22 = dbInformation.repairStatusOptionKeyValue.FirstOrDefault(kvp => kvp.Value == selectedStatus2);
                        dbInformation.tempUpdateRepairStatusHolder.Clear();
                        dbInformation.tempUpdateRepairStatusHolder[selectedKvp22.Key] = selectedKvp22.Value;

                        dbMethods.updateRepairStatus();
                        dbMethods.loadRepairActionKeyValueStatus();
                        modifiedListBox.Items.Clear(); 
                        modifiedListBox.Items.AddRange(dbInformation.clearedRepairsValueStatusPair.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());

                        this.Close(); 
                    }
                    break;

                case "Issue":
                    if (listBox1.SelectedItem != null)
                    {
                        var selectedIssueString = modifiedListBox.SelectedItem as string;
                        var selectedIssue = selectedIssueString?.Split('(')[0].Trim();
                        var selectedKvp = dbInformation.reportedIssueKeyValue.FirstOrDefault(kvp => kvp.Value == (string?)selectedIssue);
                        dbInformation.tempUpdateIssueIssueHolder.Clear();
                        dbInformation.tempUpdateIssueIssueHolder[selectedKvp.Key] = selectedKvp.Value;

                        var selectedStatus = listBox1.SelectedItem;
                        var selectedKvp2 = dbInformation.issueStatusOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == selectedStatus);
                        dbInformation.tempUpdateIssueStatusHolder.Clear();
                        dbInformation.tempUpdateIssueStatusHolder[selectedKvp2.Key] = selectedKvp2.Value;

                        dbMethods.updateIssueStatus();
                        dbMethods.loadReportedIssuesAndStatus();
                        modifiedListBox.Items.Clear(); 
                        modifiedListBox.Items.AddRange(dbInformation.reportedIssuesValueStatus.Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray());

                        this.Close(); 
                    }
                    break;

                case "Test": 
                    if (listBox1.SelectedItem != null)
                    {
                        var selectedTestString = modifiedListBox.SelectedItem as string;
                        var selectedTest = selectedTestString?.Split('(')[0].Trim();
                        var selectedKvpp = dbInformation.addedTestsKeyValue.FirstOrDefault(kvp => kvp.Value == (string?)selectedTest);
                        dbInformation.tempTestTestHolder.Clear();
                        dbInformation.tempTestTestHolder[selectedKvpp.Key] = selectedKvpp.Value;

                        var selectedStatus = listBox1.SelectedItem as string;
                        var selectedKvp = dbInformation.testStatusOptionsKeyValue.FirstOrDefault(kvp => kvp.Value == (string?)selectedStatus);
                        dbInformation.tempTestStatusHolder.Clear();
                        dbInformation.tempTestStatusHolder[selectedKvp.Key] = selectedKvp.Value;

                        dbMethods.updateTestStatus();
                        dbMethods.getAddedTestsByTwigTicket();  
                        modifiedListBox.Items.Clear();
                        modifiedListBox.Items.AddRange(
                        dbInformation.addedTestsKeyValue.Select(
                        kvp => $"{kvp.Value} ({dbInformation.addedTestsKeyStatus.GetValueOrDefault(kvp.Key)})").ToArray()
                        );

                        this.Close(); 
                    }
                    break; 

                default:
                    break;
            }
            

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
