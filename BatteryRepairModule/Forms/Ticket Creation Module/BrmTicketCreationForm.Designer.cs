using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class BrmTicketCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            twigTicketNumContainer = new Panel();
            twigTicketNumberTextBox = new MaskedTextBox();
            label1 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            batteryTypeDropDown = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            batterySerialNumberTextBox = new MaskedTextBox();
            label4 = new Label();
            panel4 = new Panel();
            vehicleVinNumberTextBox = new MaskedTextBox();
            label5 = new Label();
            panel5 = new Panel();
            staffInitiatingReportDropDown = new ComboBox();
            label6 = new Label();
            continueButton = new Button();
            cancelButton = new Button();
            twigTicketNumContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // twigTicketNumContainer
            // 
            twigTicketNumContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            twigTicketNumContainer.Controls.Add(twigTicketNumberTextBox);
            twigTicketNumContainer.Controls.Add(label1);
            twigTicketNumContainer.Dock = DockStyle.Top;
            twigTicketNumContainer.Location = new Point(0, 0);
            twigTicketNumContainer.Name = "twigTicketNumContainer";
            twigTicketNumContainer.Padding = new Padding(10, 10, 10, 5);
            twigTicketNumContainer.Size = new Size(880, 80);
            twigTicketNumContainer.TabIndex = 0;
            // 
            // twigTicketNumberTextBox
            // 
            twigTicketNumberTextBox.Dock = DockStyle.Fill;
            twigTicketNumberTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberTextBox.Location = new Point(363, 10);
            twigTicketNumberTextBox.MaximumSize = new Size(500, 0);
            twigTicketNumberTextBox.Name = "twigTicketNumberTextBox";
            twigTicketNumberTextBox.Size = new Size(500, 43);
            twigTicketNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 10);
            label1.Size = new Size(353, 51);
            label1.TabIndex = 0;
            label1.Text = "TWIG Ticket Number: ";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 0);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(354, 0);
            comboBox1.MaximumSize = new Size(500, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(500, 48);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(354, 61);
            label2.TabIndex = 2;
            label2.Text = "Battery Type:                ";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(batteryTypeDropDown);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 5);
            panel2.Size = new Size(880, 80);
            panel2.TabIndex = 2;
            // 
            // batteryTypeDropDown
            // 
            batteryTypeDropDown.Dock = DockStyle.Fill;
            batteryTypeDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            batteryTypeDropDown.FormattingEnabled = true;
            batteryTypeDropDown.Location = new Point(366, 10);
            batteryTypeDropDown.MaximumSize = new Size(500, 0);
            batteryTypeDropDown.Name = "batteryTypeDropDown";
            batteryTypeDropDown.Size = new Size(500, 45);
            batteryTypeDropDown.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 140, 10);
            label3.Size = new Size(356, 51);
            label3.TabIndex = 0;
            label3.Text = "Battery Type:";
            // 
            // panel3
            // 
            panel3.Controls.Add(batterySerialNumberTextBox);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 160);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 10, 10, 5);
            panel3.Size = new Size(880, 80);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // batterySerialNumberTextBox
            // 
            batterySerialNumberTextBox.Dock = DockStyle.Fill;
            batterySerialNumberTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            batterySerialNumberTextBox.Location = new Point(372, 10);
            batterySerialNumberTextBox.MaximumSize = new Size(500, 0);
            batterySerialNumberTextBox.Name = "batterySerialNumberTextBox";
            batterySerialNumberTextBox.Size = new Size(498, 43);
            batterySerialNumberTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 10, 10);
            label4.Size = new Size(362, 65);
            label4.TabIndex = 0;
            label4.Text = "Battery Serial Number:";
            // 
            // panel4
            // 
            panel4.Controls.Add(vehicleVinNumberTextBox);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 240);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 10, 10, 5);
            panel4.Size = new Size(880, 80);
            panel4.TabIndex = 4;
            // 
            // vehicleVinNumberTextBox
            // 
            vehicleVinNumberTextBox.Dock = DockStyle.Fill;
            vehicleVinNumberTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            vehicleVinNumberTextBox.Location = new Point(372, 10);
            vehicleVinNumberTextBox.MaximumSize = new Size(500, 0);
            vehicleVinNumberTextBox.Name = "vehicleVinNumberTextBox";
            vehicleVinNumberTextBox.Size = new Size(498, 43);
            vehicleVinNumberTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 10, 10);
            label5.Size = new Size(362, 65);
            label5.TabIndex = 0;
            label5.Text = "Vehicle VIN Number: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(staffInitiatingReportDropDown);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 320);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10, 10, 10, 5);
            panel5.Size = new Size(880, 80);
            panel5.TabIndex = 5;
            // 
            // staffInitiatingReportDropDown
            // 
            staffInitiatingReportDropDown.Dock = DockStyle.Fill;
            staffInitiatingReportDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            staffInitiatingReportDropDown.FormattingEnabled = true;
            staffInitiatingReportDropDown.Location = new Point(372, 10);
            staffInitiatingReportDropDown.MaximumSize = new Size(500, 0);
            staffInitiatingReportDropDown.Name = "staffInitiatingReportDropDown";
            staffInitiatingReportDropDown.Size = new Size(498, 45);
            staffInitiatingReportDropDown.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 10);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 0, 5, 10);
            label6.Size = new Size(362, 51);
            label6.TabIndex = 0;
            label6.Text = "Staff Initiating Report: ";
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 400);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 6;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(530, 400);
            cancelButton.MaximumSize = new Size(175, 80);
            cancelButton.MinimumSize = new Size(175, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 80);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // BrmTicketCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(880, 491);
            Controls.Add(cancelButton);
            Controls.Add(continueButton);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(twigTicketNumContainer);
            MinimumSize = new Size(0, 530);
            Name = "BrmTicketCreationForm";
            Text = "BrmTicketCreationForm";
            twigTicketNumContainer.ResumeLayout(false);
            twigTicketNumContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel twigTicketNumContainer;
        private Label label1;
        private MaskedTextBox twigTicketNumberTextBox;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panel2;
        private ComboBox batteryTypeDropDown;
        private Label label3;
        private Panel panel3;
        private MaskedTextBox batterySerialNumberTextBox;
        private Label label4;
        private Panel panel4;
        private MaskedTextBox vehicleVinNumberTextBox;
        private Label label5;
        private Panel panel5;
        private ComboBox staffInitiatingReportDropDown;
        private Label label6;
        private Button continueButton;
        private Button cancelButton;
    }
}