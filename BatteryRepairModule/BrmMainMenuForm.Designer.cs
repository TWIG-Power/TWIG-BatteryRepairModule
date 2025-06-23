using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class BrmMainMenuForm
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
            menuPanel = new Panel();
            panel1 = new Panel();
            button5 = new Button();
            testingQualityModButton = new Button();
            repairActionModButton = new Button();
            authorizeReportModButton = new Button();
            serviceInspectionModButton = new Button();
            ticketCreationModButton = new Button();
            logoPanel = new Panel();
            label1 = new Label();
            headerPanel = new Panel();
            panel2 = new Panel();
            titleLabel = new Label();
            panel3 = new Panel();
            childFormContainer = new Panel();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            logoPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.InactiveCaption;
            menuPanel.Controls.Add(panel1);
            menuPanel.Controls.Add(logoPanel);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(194, 732);
            menuPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(testingQualityModButton);
            panel1.Controls.Add(repairActionModButton);
            panel1.Controls.Add(authorizeReportModButton);
            panel1.Controls.Add(serviceInspectionModButton);
            panel1.Controls.Add(ticketCreationModButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 665);
            panel1.TabIndex = 3;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            //button5.Image = Properties.Resources.icons8_shipping_50;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 375);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 0, 0);
            button5.Size = new Size(194, 75);
            button5.TabIndex = 7;
            button5.Text = "Shipping";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // testingQualityModButton
            // 
            testingQualityModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            testingQualityModButton.Dock = DockStyle.Top;
            testingQualityModButton.FlatStyle = FlatStyle.Flat;
            testingQualityModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            //testingQualityModButton.Image = Properties.Resources.icons8_quality_50;
            testingQualityModButton.ImageAlign = ContentAlignment.MiddleLeft;
            testingQualityModButton.Location = new Point(0, 300);
            testingQualityModButton.Name = "testingQualityModButton";
            testingQualityModButton.Padding = new Padding(5, 0, 0, 0);
            testingQualityModButton.Size = new Size(194, 75);
            testingQualityModButton.TabIndex = 6;
            testingQualityModButton.Text = "Testing / Quality";
            testingQualityModButton.TextAlign = ContentAlignment.MiddleLeft;
            testingQualityModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            testingQualityModButton.UseVisualStyleBackColor = true;
            testingQualityModButton.Click += testingQualityModButton_Click;
            // 
            // repairActionModButton
            // 
            repairActionModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            repairActionModButton.Dock = DockStyle.Top;
            repairActionModButton.FlatStyle = FlatStyle.Flat;
            repairActionModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            //repairActionModButton.Image = Properties.Resources.icons8_repair_50;
            repairActionModButton.Location = new Point(0, 225);
            repairActionModButton.Name = "repairActionModButton";
            repairActionModButton.Padding = new Padding(5, 0, 0, 0);
            repairActionModButton.Size = new Size(194, 75);
            repairActionModButton.TabIndex = 5;
            repairActionModButton.Text = "Repair Action(s)";
            repairActionModButton.TextAlign = ContentAlignment.MiddleLeft;
            repairActionModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            repairActionModButton.UseVisualStyleBackColor = true;
            repairActionModButton.Click += repairActionModButton_Click;
            // 
            // authorizeReportModButton
            // 
            authorizeReportModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            authorizeReportModButton.Dock = DockStyle.Top;
            authorizeReportModButton.FlatStyle = FlatStyle.Flat;
            authorizeReportModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            //authorizeReportModButton.Image = Properties.Resources.icons8_confirm_48;
            authorizeReportModButton.ImageAlign = ContentAlignment.MiddleLeft;
            authorizeReportModButton.Location = new Point(0, 150);
            authorizeReportModButton.Name = "authorizeReportModButton";
            authorizeReportModButton.Padding = new Padding(5, 0, 0, 0);
            authorizeReportModButton.Size = new Size(194, 75);
            authorizeReportModButton.TabIndex = 4;
            authorizeReportModButton.Text = "Authorize Repair Actions";
            authorizeReportModButton.TextAlign = ContentAlignment.MiddleLeft;
            authorizeReportModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            authorizeReportModButton.UseVisualStyleBackColor = true;
            authorizeReportModButton.Click += authorizeReportModButton_Click;
            // 
            // serviceInspectionModButton
            // 
            serviceInspectionModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            serviceInspectionModButton.Dock = DockStyle.Top;
            serviceInspectionModButton.FlatStyle = FlatStyle.Flat;
            serviceInspectionModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            //serviceInspectionModButton.Image = Properties.Resources.icons8_wrench_50;
            serviceInspectionModButton.ImageAlign = ContentAlignment.MiddleLeft;
            serviceInspectionModButton.Location = new Point(0, 75);
            serviceInspectionModButton.Name = "serviceInspectionModButton";
            serviceInspectionModButton.Padding = new Padding(5, 0, 0, 0);
            serviceInspectionModButton.Size = new Size(194, 75);
            serviceInspectionModButton.TabIndex = 3;
            serviceInspectionModButton.Text = "Service Inspection ";
            serviceInspectionModButton.TextAlign = ContentAlignment.MiddleLeft;
            serviceInspectionModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            serviceInspectionModButton.UseVisualStyleBackColor = true;
            serviceInspectionModButton.Click += serviceInspectionModButton_Click;
            // 
            // ticketCreationModButton
            // 
            ticketCreationModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ticketCreationModButton.Dock = DockStyle.Top;
            ticketCreationModButton.FlatStyle = FlatStyle.Flat;
            ticketCreationModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            //ticketCreationModButton.Image = Properties.Resources.icons8_report_50;
            ticketCreationModButton.ImageAlign = ContentAlignment.MiddleLeft;
            ticketCreationModButton.Location = new Point(0, 0);
            ticketCreationModButton.Name = "ticketCreationModButton";
            ticketCreationModButton.Padding = new Padding(5, 0, 0, 0);
            ticketCreationModButton.Size = new Size(194, 75);
            ticketCreationModButton.TabIndex = 2;
            ticketCreationModButton.Text = "Ticket Creation ";
            ticketCreationModButton.TextAlign = ContentAlignment.MiddleLeft;
            ticketCreationModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ticketCreationModButton.UseVisualStyleBackColor = true;
            ticketCreationModButton.Click += ticketCreationModButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.LightSteelBlue;
            logoPanel.Controls.Add(label1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(194, 67);
            logoPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 17);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 3;
            label1.Text = "TWIG POWER";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.InactiveCaption;
            headerPanel.Controls.Add(panel2);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(194, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1006, 67);
            headerPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(438, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(169, 37);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "MAIN MENU";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 67);
            panel3.TabIndex = 2;
            // 
            // childFormContainer
            // 
            childFormContainer.Dock = DockStyle.Fill;
            childFormContainer.Location = new Point(194, 67);
            childFormContainer.Name = "childFormContainer";
            childFormContainer.Size = new Size(1006, 665);
            childFormContainer.TabIndex = 3;
            // 
            // BrmMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 732);
            Controls.Add(childFormContainer);
            Controls.Add(panel3);
            Controls.Add(headerPanel);
            Controls.Add(menuPanel);
            MinimumSize = new Size(1216, 771);
            Name = "BrmMainMenuForm";
            Text = "BrmMainMenuForm";
            menuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Panel headerPanel;
        private Panel logoPanel;
        private Panel panel1;
        private Button ticketCreationModButton;
        private Button button5;
        private Button testingQualityModButton;
        private Button repairActionModButton;
        private Button authorizeReportModButton;
        private Button serviceInspectionModButton;
        private Label titleLabel;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel childFormContainer;
    }
}