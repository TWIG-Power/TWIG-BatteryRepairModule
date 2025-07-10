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
using BatteryRepairModule.Forms.Shipping;
using BatteryRepairModule.Forms.Testing;

namespace BatteryRepairModule.Forms.BRM;

public partial class BrmMainMenuForm : Form
{
    private Form activeForm;
    private Button selectedButton;
    private string name;

    // Declare the buttons as class-level fields
    private Button closeButton;
    private Button maximizeButton;
    private Button minimizeButton;
    private Panel customTitlebar; 

    public BrmMainMenuForm()
    {
        InitializeComponent();
        dbMethods.getTicketStatusOptions();
        customTitleBar();
    }

    private void SelectButton(Button button)
    {
        try
        {
            ResetAllButtons();
            selectedButton = button;

            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.SteelBlue;
            button.FlatAppearance.BorderSize = 6;
            button.FlatAppearance.BorderColor = Color.DarkRed;
            name = button.Text.ToString();
            titleLabel.Text = name;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ResetAllButtons()
    {
        try
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
                btn.BackColor = Color.SteelBlue;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.Black;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ticketCreationModButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(ticketCreationModButton);
            OpenChildForm(new BrmTicketCreationForm(this));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void serviceInspectionModButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(serviceInspectionModButton);
            OpenChildForm(new serviceInspectionForm1(this));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void authorizeReportModButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(authorizeReportModButton);
            OpenChildForm(new BrmAuthorizeRepairsForm(this));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void repairActionModButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(repairActionModButton);
            OpenChildForm(new BrmRepairActionForm(this));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void testingQualityModButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(testingQualityModButton);
            OpenChildForm(new testingForm(this));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void qualityButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(qualityButton);
            OpenChildForm(new Forms.Quality.qualityForm1(this));
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    public void OpenChildForm(Form childForm)
    {
        try
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
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void shippingButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(shippingButton);
            OpenChildForm(new shippingForm());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void statusReviewButton_Click(object sender, EventArgs e)
    {
        try
        {
            SelectButton(statusReviewButton);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void customTitleBar()
    {
        this.FormBorderStyle = FormBorderStyle.None;

        customTitlebar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 110,
            BackColor = Color.Black
        };

        // Initialize the buttons
        closeButton = new Button
        {
            Text = "X",
            Dock = DockStyle.Right,
            Width = 180,
            Height = 110, 
            BackColor = Color.Red,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };

        maximizeButton = new Button
        {
            Text = "🗖",
            Dock = DockStyle.Right,
            Width = 180, 
            Height = 110,
            BackColor = Color.Gray,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };

        minimizeButton = new Button
        {
            Text = "—",
            Dock = DockStyle.Right,
            Width = 180,
            Height = 110, 
            BackColor = Color.Gray,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };

        // Enable dragging the form by the custom title bar
        bool dragging = false;
        Point dragCursorPoint = Point.Empty;
        Point dragFormPoint = Point.Empty;

        customTitlebar.MouseDown += (s, e) =>
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        };

        customTitlebar.MouseMove += (s, e) =>
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        };

        customTitlebar.MouseUp += (s, e) =>
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        };

        // Add event handlers
        minimizeButton.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
        maximizeButton.Click += (s, e) =>
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        };
        closeButton.Click += (s, e) => this.Close();

        customTitlebar.Controls.Add(minimizeButton);
        customTitlebar.Controls.Add(maximizeButton);
        customTitlebar.Controls.Add(closeButton);

        this.Controls.Add(customTitlebar);

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        pictureBox1.Width = 250;
        pictureBox1.Height = 250;
        pictureBox1.Refresh();

        closeButton.Height = 30;
        closeButton.Width = 60;
        minimizeButton.Height = 30;
        minimizeButton.Width = 60;
        maximizeButton.Height = 30;
        maximizeButton.Width = 60;

        customTitlebar.Height = 45; 

        closeButton.Refresh();
        minimizeButton.Refresh();
        maximizeButton.Refresh(); 
    }
}
