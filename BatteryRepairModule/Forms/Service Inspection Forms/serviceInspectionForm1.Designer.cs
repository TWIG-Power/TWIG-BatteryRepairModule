namespace BatteryRepairModule.Forms.Service_Inspection_Forms
{
    partial class serviceInspectionForm1
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
            panel3 = new Panel();
            staffDropDown = new ComboBox();
            label5 = new Label();
            panel5 = new Panel();
            noCleanProcedButton = new RadioButton();
            yesCleanProcButton = new RadioButton();
            label6 = new Label();
            panel2 = new Panel();
            noDiagnosticButton = new RadioButton();
            yesDiagnosticButton = new RadioButton();
            label3 = new Label();
            panel4 = new Panel();
            attachFileButton = new Button();
            diagnosticReportPath = new MaskedTextBox();
            label2 = new Label();
            backButton = new Button();
            continueButton = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(931, 86);
            panel1.TabIndex = 9;
            // 
            // twigTicketNumberDropDown
            // 
            twigTicketNumberDropDown.Dock = DockStyle.Fill;
            twigTicketNumberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberDropDown.FormattingEnabled = true;
            twigTicketNumberDropDown.Location = new Point(458, 20);
            twigTicketNumberDropDown.MaximumSize = new Size(500, 0);
            twigTicketNumberDropDown.Name = "twigTicketNumberDropDown";
            twigTicketNumberDropDown.Size = new Size(453, 45);
            twigTicketNumberDropDown.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 95, 10);
            label4.Size = new Size(438, 51);
            label4.TabIndex = 0;
            label4.Text = "TWIG Ticket Number: ";
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(staffDropDown);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 86);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(931, 86);
            panel3.TabIndex = 15;
            // 
            // staffDropDown
            // 
            staffDropDown.Dock = DockStyle.Fill;
            staffDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            staffDropDown.FormattingEnabled = true;
            staffDropDown.Location = new Point(458, 20);
            staffDropDown.MaximumSize = new Size(500, 0);
            staffDropDown.Name = "staffDropDown";
            staffDropDown.Size = new Size(453, 45);
            staffDropDown.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 20);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 10, 10);
            label5.Size = new Size(438, 51);
            label5.TabIndex = 0;
            label5.Text = "Staff Performing Inspection:";
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(noCleanProcedButton);
            panel5.Controls.Add(yesCleanProcButton);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 172);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20);
            panel5.Size = new Size(931, 87);
            panel5.TabIndex = 16;
            // 
            // noCleanProcedButton
            // 
            noCleanProcedButton.AutoSize = true;
            noCleanProcedButton.Dock = DockStyle.Left;
            noCleanProcedButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            noCleanProcedButton.Location = new Point(535, 20);
            noCleanProcedButton.Name = "noCleanProcedButton";
            noCleanProcedButton.Padding = new Padding(20, 0, 20, 0);
            noCleanProcedButton.Size = new Size(118, 47);
            noCleanProcedButton.TabIndex = 2;
            noCleanProcedButton.TabStop = true;
            noCleanProcedButton.Text = "No ";
            noCleanProcedButton.UseVisualStyleBackColor = true;
            // 
            // yesCleanProcButton
            // 
            yesCleanProcButton.AutoSize = true;
            yesCleanProcButton.Dock = DockStyle.Left;
            yesCleanProcButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            yesCleanProcButton.Location = new Point(422, 20);
            yesCleanProcButton.Name = "yesCleanProcButton";
            yesCleanProcButton.Padding = new Padding(20, 0, 20, 0);
            yesCleanProcButton.Size = new Size(113, 47);
            yesCleanProcButton.TabIndex = 1;
            yesCleanProcButton.TabStop = true;
            yesCleanProcButton.Text = "Yes";
            yesCleanProcButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 0, 25, 10);
            label6.Size = new Size(402, 51);
            label6.TabIndex = 0;
            label6.Text = "Battery / Module Clean? ";
            // 
            // panel2
            // 
            panel2.Controls.Add(noDiagnosticButton);
            panel2.Controls.Add(yesDiagnosticButton);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 259);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(931, 88);
            panel2.TabIndex = 17;
            // 
            // noDiagnosticButton
            // 
            noDiagnosticButton.AutoSize = true;
            noDiagnosticButton.Dock = DockStyle.Left;
            noDiagnosticButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            noDiagnosticButton.Location = new Point(609, 20);
            noDiagnosticButton.Name = "noDiagnosticButton";
            noDiagnosticButton.Padding = new Padding(20, 0, 20, 0);
            noDiagnosticButton.Size = new Size(118, 48);
            noDiagnosticButton.TabIndex = 3;
            noDiagnosticButton.TabStop = true;
            noDiagnosticButton.Text = "No ";
            noDiagnosticButton.UseVisualStyleBackColor = true;
            // 
            // yesDiagnosticButton
            // 
            yesDiagnosticButton.AutoSize = true;
            yesDiagnosticButton.Dock = DockStyle.Left;
            yesDiagnosticButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            yesDiagnosticButton.Location = new Point(496, 20);
            yesDiagnosticButton.Name = "yesDiagnosticButton";
            yesDiagnosticButton.Padding = new Padding(20, 0, 20, 0);
            yesDiagnosticButton.Size = new Size(113, 48);
            yesDiagnosticButton.TabIndex = 2;
            yesDiagnosticButton.TabStop = true;
            yesDiagnosticButton.Text = "Yes";
            yesDiagnosticButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 25, 10);
            label3.Size = new Size(476, 51);
            label3.TabIndex = 1;
            label3.Text = "Plugged Into Diagnostic Tool?";
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(attachFileButton);
            panel4.Controls.Add(diagnosticReportPath);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 347);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(931, 80);
            panel4.TabIndex = 18;
            // 
            // attachFileButton
            // 
            attachFileButton.Dock = DockStyle.Left;
            attachFileButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            attachFileButton.Location = new Point(826, 20);
            attachFileButton.Name = "attachFileButton";
            attachFileButton.Size = new Size(105, 40);
            attachFileButton.TabIndex = 2;
            attachFileButton.Text = "Attach";
            attachFileButton.UseVisualStyleBackColor = true;
            attachFileButton.Click += attachFileButton_Click;
            // 
            // diagnosticReportPath
            // 
            diagnosticReportPath.Dock = DockStyle.Left;
            diagnosticReportPath.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            diagnosticReportPath.Location = new Point(326, 20);
            diagnosticReportPath.MaximumSize = new Size(500, 0);
            diagnosticReportPath.MinimumSize = new Size(0, 110);
            diagnosticReportPath.Name = "diagnosticReportPath";
            diagnosticReportPath.Size = new Size(500, 110);
            diagnosticReportPath.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 10, 10);
            label2.Size = new Size(306, 51);
            label2.TabIndex = 0;
            label2.Text = "Diagnostics Report";
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(581, 427);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
            backButton.TabIndex = 20;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(756, 427);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 19;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click_1;
            // 
            // serviceInspectionForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(931, 511);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "serviceInspectionForm1";
            Text = "serviceInspectionForm1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox twigTicketNumberDropDown;
        private Label label4;
        private Panel panel3;
        private ComboBox staffDropDown;
        private Label label5;
        private Panel panel5;
        private RadioButton noCleanProcedButton;
        private RadioButton yesCleanProcButton;
        private Label label6;
        private Panel panel2;
        private RadioButton noDiagnosticButton;
        private RadioButton yesDiagnosticButton;
        private Label label3;
        private Panel panel4;
        private Button attachFileButton;
        private MaskedTextBox diagnosticReportPath;
        private Label label2;
        private Button backButton;
        private Button continueButton;
    }
}