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
            statusReviewButton = new Button();
            shippingButton = new Button();
            qualityButton = new Button();
            testingQualityModButton = new Button();
            repairActionModButton = new Button();
            authorizeReportModButton = new Button();
            serviceInspectionModButton = new Button();
            ticketCreationModButton = new Button();
            logoPanel = new Panel();
            pictureBox1 = new PictureBox();
            headerPanel = new Panel();
            panel2 = new Panel();
            titleLabel = new Label();
            childFormContainer = new Panel();
            menuPanel.SuspendLayout();
            panel1.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            menuPanel.Size = new Size(194, 616);
            menuPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(statusReviewButton);
            panel1.Controls.Add(shippingButton);
            panel1.Controls.Add(qualityButton);
            panel1.Controls.Add(testingQualityModButton);
            panel1.Controls.Add(repairActionModButton);
            panel1.Controls.Add(authorizeReportModButton);
            panel1.Controls.Add(serviceInspectionModButton);
            panel1.Controls.Add(ticketCreationModButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 522);
            panel1.TabIndex = 3;
            // 
            // statusReviewButton
            // 
            statusReviewButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statusReviewButton.BackColor = Color.SteelBlue;
            statusReviewButton.Dock = DockStyle.Top;
            statusReviewButton.FlatStyle = FlatStyle.Flat;
            statusReviewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            statusReviewButton.Image = Properties.Resources.icons8_status_50;
            statusReviewButton.ImageAlign = ContentAlignment.MiddleLeft;
            statusReviewButton.Location = new Point(0, 455);
            statusReviewButton.Name = "statusReviewButton";
            statusReviewButton.Padding = new Padding(5, 0, 0, 0);
            statusReviewButton.Size = new Size(194, 65);
            statusReviewButton.TabIndex = 9;
            statusReviewButton.Text = "Status Review";
            statusReviewButton.TextAlign = ContentAlignment.MiddleLeft;
            statusReviewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            statusReviewButton.UseVisualStyleBackColor = false;
            statusReviewButton.Click += statusReviewButton_Click;
            // 
            // shippingButton
            // 
            shippingButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            shippingButton.BackColor = Color.SteelBlue;
            shippingButton.Dock = DockStyle.Top;
            shippingButton.FlatStyle = FlatStyle.Flat;
            shippingButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            shippingButton.Image = Properties.Resources.icons8_shipping_50;
            shippingButton.ImageAlign = ContentAlignment.MiddleLeft;
            shippingButton.Location = new Point(0, 390);
            shippingButton.Name = "shippingButton";
            shippingButton.Padding = new Padding(5, 0, 0, 0);
            shippingButton.Size = new Size(194, 65);
            shippingButton.TabIndex = 8;
            shippingButton.Text = "Shipping";
            shippingButton.TextAlign = ContentAlignment.MiddleLeft;
            shippingButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            shippingButton.UseVisualStyleBackColor = false;
            shippingButton.Click += shippingButton_Click;
            // 
            // qualityButton
            // 
            qualityButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            qualityButton.BackColor = Color.SteelBlue;
            qualityButton.Dock = DockStyle.Top;
            qualityButton.FlatStyle = FlatStyle.Flat;
            qualityButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            qualityButton.Image = Properties.Resources.icons8_quality_50;
            qualityButton.ImageAlign = ContentAlignment.MiddleLeft;
            qualityButton.Location = new Point(0, 325);
            qualityButton.Name = "qualityButton";
            qualityButton.Padding = new Padding(5, 0, 0, 0);
            qualityButton.Size = new Size(194, 65);
            qualityButton.TabIndex = 7;
            qualityButton.Text = "Quality";
            qualityButton.TextAlign = ContentAlignment.MiddleLeft;
            qualityButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            qualityButton.UseVisualStyleBackColor = false;
            qualityButton.Click += qualityButton_Click;
            // 
            // testingQualityModButton
            // 
            testingQualityModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            testingQualityModButton.BackColor = Color.SteelBlue;
            testingQualityModButton.Dock = DockStyle.Top;
            testingQualityModButton.FlatStyle = FlatStyle.Flat;
            testingQualityModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            testingQualityModButton.Image = Properties.Resources.icons8_testing_50;
            testingQualityModButton.ImageAlign = ContentAlignment.MiddleLeft;
            testingQualityModButton.Location = new Point(0, 260);
            testingQualityModButton.Name = "testingQualityModButton";
            testingQualityModButton.Padding = new Padding(5, 0, 0, 0);
            testingQualityModButton.Size = new Size(194, 65);
            testingQualityModButton.TabIndex = 6;
            testingQualityModButton.Text = "Testing";
            testingQualityModButton.TextAlign = ContentAlignment.MiddleLeft;
            testingQualityModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            testingQualityModButton.UseVisualStyleBackColor = false;
            testingQualityModButton.Click += testingQualityModButton_Click;
            // 
            // repairActionModButton
            // 
            repairActionModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            repairActionModButton.BackColor = Color.SteelBlue;
            repairActionModButton.Dock = DockStyle.Top;
            repairActionModButton.FlatStyle = FlatStyle.Flat;
            repairActionModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            repairActionModButton.Image = Properties.Resources.icons8_repair_50;
            repairActionModButton.Location = new Point(0, 195);
            repairActionModButton.Name = "repairActionModButton";
            repairActionModButton.Padding = new Padding(5, 0, 0, 0);
            repairActionModButton.Size = new Size(194, 65);
            repairActionModButton.TabIndex = 5;
            repairActionModButton.Text = "Repair Action(s)";
            repairActionModButton.TextAlign = ContentAlignment.MiddleLeft;
            repairActionModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            repairActionModButton.UseVisualStyleBackColor = false;
            repairActionModButton.Click += repairActionModButton_Click;
            // 
            // authorizeReportModButton
            // 
            authorizeReportModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            authorizeReportModButton.BackColor = Color.SteelBlue;
            authorizeReportModButton.Dock = DockStyle.Top;
            authorizeReportModButton.FlatStyle = FlatStyle.Flat;
            authorizeReportModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            authorizeReportModButton.Image = Properties.Resources.icons8_confirm_48;
            authorizeReportModButton.ImageAlign = ContentAlignment.MiddleLeft;
            authorizeReportModButton.Location = new Point(0, 130);
            authorizeReportModButton.Name = "authorizeReportModButton";
            authorizeReportModButton.Padding = new Padding(5, 0, 0, 0);
            authorizeReportModButton.Size = new Size(194, 65);
            authorizeReportModButton.TabIndex = 4;
            authorizeReportModButton.Text = "Authorize Repair Actions";
            authorizeReportModButton.TextAlign = ContentAlignment.MiddleLeft;
            authorizeReportModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            authorizeReportModButton.UseVisualStyleBackColor = false;
            authorizeReportModButton.Click += authorizeReportModButton_Click;
            // 
            // serviceInspectionModButton
            // 
            serviceInspectionModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            serviceInspectionModButton.BackColor = Color.SteelBlue;
            serviceInspectionModButton.Dock = DockStyle.Top;
            serviceInspectionModButton.FlatStyle = FlatStyle.Flat;
            serviceInspectionModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            serviceInspectionModButton.Image = Properties.Resources.icons8_wrench_50;
            serviceInspectionModButton.ImageAlign = ContentAlignment.MiddleLeft;
            serviceInspectionModButton.Location = new Point(0, 65);
            serviceInspectionModButton.Name = "serviceInspectionModButton";
            serviceInspectionModButton.Padding = new Padding(5, 0, 0, 0);
            serviceInspectionModButton.Size = new Size(194, 65);
            serviceInspectionModButton.TabIndex = 3;
            serviceInspectionModButton.Text = "Service Inspection ";
            serviceInspectionModButton.TextAlign = ContentAlignment.MiddleLeft;
            serviceInspectionModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            serviceInspectionModButton.UseVisualStyleBackColor = false;
            serviceInspectionModButton.Click += serviceInspectionModButton_Click;
            // 
            // ticketCreationModButton
            // 
            ticketCreationModButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ticketCreationModButton.BackColor = Color.SteelBlue;
            ticketCreationModButton.Dock = DockStyle.Top;
            ticketCreationModButton.FlatStyle = FlatStyle.Flat;
            ticketCreationModButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ticketCreationModButton.Image = Properties.Resources.icons8_report_50;
            ticketCreationModButton.ImageAlign = ContentAlignment.MiddleLeft;
            ticketCreationModButton.Location = new Point(0, 0);
            ticketCreationModButton.Name = "ticketCreationModButton";
            ticketCreationModButton.Padding = new Padding(5, 0, 0, 0);
            ticketCreationModButton.Size = new Size(194, 65);
            ticketCreationModButton.TabIndex = 2;
            ticketCreationModButton.Text = "Ticket Creation ";
            ticketCreationModButton.TextAlign = ContentAlignment.MiddleLeft;
            ticketCreationModButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ticketCreationModButton.UseVisualStyleBackColor = false;
            ticketCreationModButton.Click += ticketCreationModButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = SystemColors.ActiveCaptionText;
            logoPanel.Controls.Add(pictureBox1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(194, 94);
            logoPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.Logo1;
            pictureBox1.Location = new Point(40, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.SteelBlue;
            headerPanel.Controls.Add(panel2);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(194, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1006, 94);
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
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(438, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(180, 37);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "MAIN MENU";
            // 
            // childFormContainer
            // 
            childFormContainer.BackColor = Color.Gainsboro;
            childFormContainer.Dock = DockStyle.Fill;
            childFormContainer.Location = new Point(194, 94);
            childFormContainer.Name = "childFormContainer";
            childFormContainer.Size = new Size(1006, 522);
            childFormContainer.TabIndex = 3;
            // 
            // BrmMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 616);
            Controls.Add(childFormContainer);
            Controls.Add(headerPanel);
            Controls.Add(menuPanel);
            MinimumSize = new Size(1216, 655);
            Name = "BrmMainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrmMainMenuForm";
            WindowState = FormWindowState.Maximized;
            menuPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button qualityButton;
        private Button testingQualityModButton;
        private Button repairActionModButton;
        private Button authorizeReportModButton;
        private Button serviceInspectionModButton;
        private Label titleLabel;
        private Panel panel2;
        private Panel childFormContainer;
        private PictureBox pictureBox1;
        private Button statusReviewButton;
        private Button shippingButton;
    }
}