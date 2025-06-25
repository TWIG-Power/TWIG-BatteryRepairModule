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
    private Button selectedButton;
    private string name;

    public BrmMainMenuForm()
    {
        InitializeComponent();
    }

    private void SelectButton(Button button)
    {
        ResetAllButtons();
        selectedButton = button;

        button.FlatStyle = FlatStyle.Flat;
        button.BackColor = Color.LightBlue;
        button.FlatAppearance.BorderSize = 6;
        button.FlatAppearance.BorderColor = Color.DarkRed;
        name = button.Text.ToString();
        titleLabel.Text = name;
    }

    private void ResetAllButtons()
    {
        var menuButtons = new[]
        {
            ticketCreationModButton,
            serviceInspectionModButton,
            authorizeReportModButton,
            repairActionModButton,
            testingQualityModButton,
            qualityButton,
            shippingButton,
            statusReviewButton
        };

        foreach (var btn in menuButtons)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.LightBlue;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Black;
        }
    }

    private void ticketCreationModButton_Click(object sender, EventArgs e)
    {
        SelectButton(ticketCreationModButton);
        OpenChildForm(new BrmTicketCreationForm(this));
    }

    private void serviceInspectionModButton_Click(object sender, EventArgs e)
    {
        SelectButton(serviceInspectionModButton);
        OpenChildForm(new serviceInspectionForm1(this));
    }

    private void authorizeReportModButton_Click(object sender, EventArgs e)
    {
        SelectButton(authorizeReportModButton);
        OpenChildForm(new BrmAuthorizeRepairsForm());
    }

    private void repairActionModButton_Click(object sender, EventArgs e)
    {
        SelectButton(repairActionModButton);
        OpenChildForm(new BrmRepairActionForm());
    }

    private void testingQualityModButton_Click(object sender, EventArgs e)
    {
        SelectButton(testingQualityModButton);
    }

    private void qualityButton_Click(object sender, EventArgs e)
    {
        SelectButton(qualityButton);
        OpenChildForm(new Forms.Quality.qualityForm1(this));
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

    private void shippingButton_Click(object sender, EventArgs e)
    {
        SelectButton(shippingButton);
    }

    private void statusReviewButton_Click(object sender, EventArgs e)
    {
        SelectButton(statusReviewButton); 
    }
}
