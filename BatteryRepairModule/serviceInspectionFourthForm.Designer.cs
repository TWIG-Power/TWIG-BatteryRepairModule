using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class serviceInspectionFourthForm
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
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            twigTicketNumContainer = new Panel();
            attachButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            repairActionsListBox = new ListBox();
            panel6 = new Panel();
            reportedIssuesListBox = new ListBox();
            panel9 = new Panel();
            panel11 = new Panel();
            button2 = new Button();
            panel10 = new Panel();
            button1 = new Button();
            backButton = new Button();
            continueButton = new Button();
            panel2.SuspendLayout();
            twigTicketNumContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 5);
            panel2.Size = new Size(880, 80);
            panel2.TabIndex = 4;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Left;
            radioButton2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(643, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(20, 0, 20, 0);
            radioButton2.Size = new Size(118, 65);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "No ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Left;
            radioButton1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(530, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(20, 0, 20, 0);
            radioButton1.Size = new Size(113, 65);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Yes";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 25, 10);
            label3.Size = new Size(520, 51);
            label3.TabIndex = 0;
            label3.Text = "Cleaning Procedures Completed: ";
            // 
            // twigTicketNumContainer
            // 
            twigTicketNumContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            twigTicketNumContainer.Controls.Add(attachButton);
            twigTicketNumContainer.Controls.Add(maskedTextBox1);
            twigTicketNumContainer.Controls.Add(label1);
            twigTicketNumContainer.Dock = DockStyle.Top;
            twigTicketNumContainer.Location = new Point(0, 80);
            twigTicketNumContainer.Name = "twigTicketNumContainer";
            twigTicketNumContainer.Padding = new Padding(10, 10, 10, 5);
            twigTicketNumContainer.Size = new Size(880, 62);
            twigTicketNumContainer.TabIndex = 5;
            // 
            // attachButton
            // 
            attachButton.Dock = DockStyle.Left;
            attachButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            attachButton.Location = new Point(734, 10);
            attachButton.Name = "attachButton";
            attachButton.Size = new Size(137, 47);
            attachButton.TabIndex = 2;
            attachButton.Text = "Attach";
            attachButton.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Dock = DockStyle.Left;
            maskedTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(316, 10);
            maskedTextBox1.MaximumSize = new Size(500, 0);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(418, 43);
            maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 10);
            label1.Size = new Size(306, 51);
            label1.TabIndex = 0;
            label1.Text = "Diagnostics Report";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 142);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 10, 10, 5);
            panel1.Size = new Size(880, 62);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(492, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 10, 10);
            label4.Size = new Size(242, 51);
            label4.TabIndex = 6;
            label4.Text = "Repair Actions";
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(271, 10);
            panel8.Name = "panel8";
            panel8.Size = new Size(221, 47);
            panel8.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Location = new Point(288, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 10, 10);
            label2.Size = new Size(261, 51);
            label2.TabIndex = 0;
            label2.Text = "Reported Issues";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(880, 187);
            panel5.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(repairActionsListBox);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(reportedIssuesListBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 185);
            panel3.TabIndex = 10;
            // 
            // repairActionsListBox
            // 
            repairActionsListBox.Dock = DockStyle.Left;
            repairActionsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            repairActionsListBox.FormattingEnabled = true;
            repairActionsListBox.ItemHeight = 32;
            repairActionsListBox.Location = new Point(458, 0);
            repairActionsListBox.Name = "repairActionsListBox";
            repairActionsListBox.Size = new Size(421, 185);
            repairActionsListBox.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(421, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(37, 185);
            panel6.TabIndex = 4;
            // 
            // reportedIssuesListBox
            // 
            reportedIssuesListBox.Dock = DockStyle.Left;
            reportedIssuesListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            reportedIssuesListBox.FormattingEnabled = true;
            reportedIssuesListBox.ItemHeight = 32;
            reportedIssuesListBox.Location = new Point(0, 0);
            reportedIssuesListBox.Name = "reportedIssuesListBox";
            reportedIssuesListBox.Size = new Size(421, 185);
            reportedIssuesListBox.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 391);
            panel9.Name = "panel9";
            panel9.Size = new Size(880, 82);
            panel9.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.Controls.Add(button2);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(441, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(441, 82);
            panel11.TabIndex = 17;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(441, 79);
            button2.TabIndex = 19;
            button2.Text = "Remove Repair Action";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(button1);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(441, 82);
            panel10.TabIndex = 16;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(441, 79);
            button1.TabIndex = 18;
            button1.Text = "Add Repair Action";
            button1.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(530, 473);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
            backButton.TabIndex = 17;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 473);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 16;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // serviceInspectionFourthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 556);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(twigTicketNumContainer);
            Controls.Add(panel2);
            Name = "serviceInspectionFourthForm";
            Text = "serviceInspectionFourthForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            twigTicketNumContainer.ResumeLayout(false);
            twigTicketNumContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Panel twigTicketNumContainer;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Button attachButton;
        private Panel panel1;
        private Label label2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private ListBox reportedIssuesListBox;
        private ListBox repairActionsListBox;
        private Panel panel6;
        private Label label4;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Button button2;
        private Panel panel10;
        private Button button1;
        private Button backButton;
        private Button continueButton;
    }
}