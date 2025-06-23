using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteryRepairModule.Forms.Service_Inspection_Forms;

namespace BatteryRepairModule.Forms.BRM;

public partial class BrmMainMenuForm : Form
{
    private Form activeForm;
    bool safeToClose = false;
    public BrmMainMenuForm()
    {
        InitializeComponent();
        this.FormClosing += formCloser;
    }

    private void formCloser(object sender, EventArgs e)
    {
        if (!safeToClose)
        {

        }
    }

    private void ticketCreationModButton_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.BRM.BrmTicketCreationForm(this));
    }

    private void serviceInspectionModButton_Click(object sender, EventArgs e)
    {
        OpenChildForm(new serviceInspectionForm1(this));
    }

    private void authorizeReportModButton_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.BRM.BrmAuthorizeRepairsForm());
    }

    private void repairActionModButton_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.BRM.BrmRepairActionForm());
    }

    private void testingQualityModButton_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {

    }

    public void OpenChildForm(Form childForm)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }
        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        this.childFormContainer.Controls.Add(childForm);
        this.childFormContainer.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
    }
}
