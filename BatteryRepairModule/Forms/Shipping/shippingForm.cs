﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryRepairModule.Forms.Shipping
{
    public partial class shippingForm : Form
    {
        private List<string> oemOptions = new List<string> { "Cobra", "KTM", "Misc", "All" };
        private List<string> stateOfHealthOptions = new List<string> { "Race Grade", "Track Grade", "Play Grade", "All" };
        public shippingForm()
        {
            InitializeComponent();

            ThemeHelper.ApplyTheme(this); 
            
            reloadModules(); 

            moduleOemFilterDropDown.Items.AddRange(oemOptions.ToArray());
            stateOfHealthFilterDropDown.Items.AddRange(stateOfHealthOptions.ToArray());
        }

        private void stateOfHealthFilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (moduleOemFilterDropDown.SelectedItem == null)
                    filterByStateOfHealthFirst();
                else
                    filterByStateOfHealthFirst();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moduleOemFilterDropDown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (stateOfHealthFilterDropDown.SelectedItem == null)
                    filterByOemFirst();
                else
                    filterByOemFirst(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void markModuleAsInvoiced_Click(object sender, EventArgs e)
        {
            try
            {
                if (readyInventoryListBox.SelectedItem == null)
                {
                    MessageBox.Show("No module selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedItem = readyInventoryListBox.SelectedItem.ToString();
                int modified = Int32.Parse(selectedItem.Split('[')[1].Split(']')[0]);


                Module selectedModule = dbInformation.awaitingInvoiceModuleList.FirstOrDefault(item => item.ticketId == modified);

                if (selectedModule != null)
                {
                    dbMethods.clearModuleForShipping(selectedModule);

                    reloadModules();
                    MessageBox.Show("Module marked as invoiced successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected module not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reloadModules()
        {
            try
            {
                readyInventoryListBox.Items.Clear();
                invoicedListBox.Items.Clear();

                dbMethods.loadModulesAwaitingInvoiceTickets();
                foreach (Module item in dbInformation.awaitingInvoiceModuleList)
                {
                    readyInventoryListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                }

                dbMethods.loadModulesAwaitingShipping();
                foreach (Module item in dbInformation.awaitingShippingModuleList)
                {
                    invoicedListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void markModuleAsShipped_Click(object sender, EventArgs e)
        {
            try
            {
                if (invoicedListBox.SelectedItem == null)
                {
                    MessageBox.Show("No module selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedItem = invoicedListBox.SelectedItem.ToString();
                int modified = Int32.Parse(selectedItem.Split('[')[1].Split(']')[0]);

                Module selectedModule = dbInformation.awaitingShippingModuleList.FirstOrDefault(item => item.ticketId == modified);

                if (selectedModule == null)
                {
                    MessageBox.Show("Selected module not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dbMethods.clearModuleAsShippedOrClosed(selectedModule);
                reloadModules(); 
                MessageBox.Show("Module marked as shipped successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterByStateOfHealthFirst()
        {
            try
            {
                if (stateOfHealthFilterDropDown.SelectedItem == null)
                    return;

                string selectedItem = stateOfHealthFilterDropDown.SelectedItem.ToString();

                readyInventoryListBox.Items.Clear();
                invoicedListBox.Items.Clear();

                if (stateOfHealthFilterDropDown.SelectedItem == "All")
                {
                    foreach (Module item in dbInformation.awaitingInvoiceModuleList)
                    {
                        readyInventoryListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                    foreach (Module item in dbInformation.awaitingShippingModuleList)
                    {
                        invoicedListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                    return; 
                }

                foreach (Module item in dbInformation.awaitingInvoiceModuleList)
                {
                    if (item.stateOfHealth == selectedItem)
                    {
                        readyInventoryListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                }

                foreach (Module item in dbInformation.awaitingShippingModuleList)
                {
                    if (item.stateOfHealth == selectedItem)
                    {
                        invoicedListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterByOemFirst()
        {
            try
            {
                if (moduleOemFilterDropDown.SelectedItem == null)
                    return;

                string selectedItem = moduleOemFilterDropDown.SelectedItem.ToString();

                readyInventoryListBox.Items.Clear();
                invoicedListBox.Items.Clear();
                
                if (moduleOemFilterDropDown.SelectedItem == "All")
                {
                    foreach (Module item in dbInformation.awaitingInvoiceModuleList)
                    {
                        readyInventoryListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                    foreach (Module item in dbInformation.awaitingShippingModuleList)
                    {
                        invoicedListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                    return; 
                }

                foreach (Module item in dbInformation.awaitingInvoiceModuleList)
                {
                    if (item.Oem == selectedItem)
                    {
                        readyInventoryListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                }

                foreach (Module item in dbInformation.awaitingShippingModuleList)
                {
                    if (item.Oem == selectedItem) 
                    {
                        invoicedListBox.Items.Add($"[{item.ticketId}] - [{item.model}] - {item.SerialNumber} ({item.stateOfHealth})");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
