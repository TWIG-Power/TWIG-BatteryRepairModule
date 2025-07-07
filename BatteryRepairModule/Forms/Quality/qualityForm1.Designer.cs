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
            backButton = new Button();
            continueButton = new Button();
            addNewChecklist = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
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
            attachFileButton.Size = new Size(105, 73);
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
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(581, 278);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
            backButton.TabIndex = 22;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click_1;
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(756, 278);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 21;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click_1;
            // 
            // addNewChecklist
            // 
            addNewChecklist.AutoSize = true;
            addNewChecklist.Dock = DockStyle.Left;
            addNewChecklist.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addNewChecklist.Location = new Point(0, 278);
            addNewChecklist.MaximumSize = new Size(175, 80);
            addNewChecklist.MinimumSize = new Size(175, 80);
            addNewChecklist.Name = "addNewChecklist";
            addNewChecklist.Size = new Size(175, 80);
            addNewChecklist.TabIndex = 23;
            addNewChecklist.Text = "Upload new checklist version";
            addNewChecklist.UseVisualStyleBackColor = true;
            addNewChecklist.Click += addNewChecklist_Click;
            // 
            // qualityForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 511);
            Controls.Add(addNewChecklist);
            Controls.Add(backButton);
            Controls.Add(continueButton);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Button backButton;
        private Button continueButton;
        private Button addNewChecklist;
    }
}