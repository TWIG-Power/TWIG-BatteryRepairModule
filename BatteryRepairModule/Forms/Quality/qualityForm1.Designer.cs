namespace BatteryRepairModule.Forms.Quality
{
    partial class qualityForm1
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
            panel1 = new Panel();
            twigTicketNumberDropDown = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            staffInitiatingReportDropDown = new ComboBox();
            label6 = new Label();
            panel2 = new Panel();
            attachFileButton = new Button();
            qualityChecklistPathTextBox = new MaskedTextBox();
            label1 = new Label();
            addNewChecklist = new Button();
            panel16 = new Panel();
            panel14 = new Panel();
            continueButton = new Button();
            panel15 = new Panel();
            backButton = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel16.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(twigTicketNumberDropDown);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(931, 102);
            panel1.TabIndex = 10;
            // 
            // twigTicketNumberDropDown
            // 
            twigTicketNumberDropDown.Dock = DockStyle.Fill;
            twigTicketNumberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberDropDown.FormattingEnabled = true;
            twigTicketNumberDropDown.Location = new Point(383, 20);
            twigTicketNumberDropDown.MaximumSize = new Size(500, 0);
            twigTicketNumberDropDown.Name = "twigTicketNumberDropDown";
            twigTicketNumberDropDown.Size = new Size(500, 45);
            twigTicketNumberDropDown.TabIndex = 2;
            twigTicketNumberDropDown.SelectedIndexChanged += twigTicketNumberDropDown_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 30, 0);
            label4.Size = new Size(363, 41);
            label4.TabIndex = 0;
            label4.Text = "TWIG Ticket Number: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(staffInitiatingReportDropDown);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 102);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10, 10, 10, 5);
            panel5.Size = new Size(931, 88);
            panel5.TabIndex = 11;
            // 
            // staffInitiatingReportDropDown
            // 
            staffInitiatingReportDropDown.Dock = DockStyle.Fill;
            staffInitiatingReportDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            staffInitiatingReportDropDown.FormattingEnabled = true;
            staffInitiatingReportDropDown.Location = new Point(392, 10);
            staffInitiatingReportDropDown.MaximumSize = new Size(500, 0);
            staffInitiatingReportDropDown.Name = "staffInitiatingReportDropDown";
            staffInitiatingReportDropDown.Size = new Size(500, 45);
            staffInitiatingReportDropDown.TabIndex = 1;
            staffInitiatingReportDropDown.SelectedIndexChanged += staffInitiatingReportDropDown_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 10);
            label6.Name = "label6";
            label6.Size = new Size(382, 41);
            label6.TabIndex = 0;
            label6.Text = "Staff Performing Quality: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(attachFileButton);
            panel2.Controls.Add(qualityChecklistPathTextBox);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 190);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 5);
            panel2.Size = new Size(931, 88);
            panel2.TabIndex = 12;
            // 
            // attachFileButton
            // 
            attachFileButton.Dock = DockStyle.Left;
            attachFileButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            attachFileButton.Location = new Point(817, 10);
            attachFileButton.Name = "attachFileButton";
            attachFileButton.Size = new Size(110, 73);
            attachFileButton.TabIndex = 4;
            attachFileButton.Text = "Attach";
            attachFileButton.UseVisualStyleBackColor = true;
            attachFileButton.Click += attachFileButton_Click;
            // 
            // qualityChecklistPathTextBox
            // 
            qualityChecklistPathTextBox.Dock = DockStyle.Left;
            qualityChecklistPathTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            qualityChecklistPathTextBox.Location = new Point(317, 10);
            qualityChecklistPathTextBox.MaximumSize = new Size(500, 0);
            qualityChecklistPathTextBox.MinimumSize = new Size(0, 110);
            qualityChecklistPathTextBox.Name = "qualityChecklistPathTextBox";
            qualityChecklistPathTextBox.Size = new Size(500, 110);
            qualityChecklistPathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 40, 0);
            label1.Size = new Size(307, 41);
            label1.TabIndex = 0;
            label1.Text = "Quality checklist: ";
            // 
            // addNewChecklist
            // 
            addNewChecklist.AutoSize = true;
            addNewChecklist.Dock = DockStyle.Left;
            addNewChecklist.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addNewChecklist.Location = new Point(3, 3);
            addNewChecklist.MaximumSize = new Size(1220, 80);
            addNewChecklist.MinimumSize = new Size(175, 80);
            addNewChecklist.Name = "addNewChecklist";
            addNewChecklist.Size = new Size(333, 80);
            addNewChecklist.TabIndex = 23;
            addNewChecklist.Text = "Upload new checklist version";
            addNewChecklist.UseVisualStyleBackColor = true;
            addNewChecklist.Click += addNewChecklist_Click;
            // 
            // panel16
            // 
            panel16.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel16.Controls.Add(panel14);
            panel16.Controls.Add(panel15);
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(500, 278);
            panel16.Name = "panel16";
            panel16.Size = new Size(431, 233);
            panel16.TabIndex = 24;
            // 
            // panel14
            // 
            panel14.Controls.Add(continueButton);
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(215, 0);
            panel14.MaximumSize = new Size(500, 83);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(3);
            panel14.Size = new Size(215, 83);
            panel14.TabIndex = 20;
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Fill;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(3, 3);
            continueButton.MinimumSize = new Size(175, 50);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(209, 77);
            continueButton.TabIndex = 15;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(backButton);
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(0, 0);
            panel15.MaximumSize = new Size(500, 83);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(3);
            panel15.Size = new Size(215, 83);
            panel15.TabIndex = 21;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Fill;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(3, 3);
            backButton.MinimumSize = new Size(175, 40);
            backButton.Name = "backButton";
            backButton.Size = new Size(209, 77);
            backButton.TabIndex = 17;
            backButton.Text = "Back ";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(addNewChecklist);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 278);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3);
            panel3.Size = new Size(497, 233);
            panel3.TabIndex = 25;
            // 
            // qualityForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 511);
            Controls.Add(panel3);
            Controls.Add(panel16);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            MinimumSize = new Size(947, 550);
            Name = "qualityForm1";
            Text = "qualityForm1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel16.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox twigTicketNumberDropDown;
        private Label label4;
        private Panel panel5;
        private ComboBox staffInitiatingReportDropDown;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private Button attachFileButton;
        private MaskedTextBox qualityChecklistPathTextBox;
        private Button addNewChecklist;
        private Panel panel16;
        private Panel panel14;
        private Button continueButton;
        private Panel panel15;
        private Button backButton;
        private Panel panel3;
    }
}