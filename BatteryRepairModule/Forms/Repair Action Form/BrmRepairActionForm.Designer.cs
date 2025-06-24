using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class BrmRepairActionForm
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
            panel12 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel8 = new Panel();
            twigTicketNumberDropDown = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            panel9 = new Panel();
            notesTextBox = new RichTextBox();
            panel2 = new Panel();
            repairActionsListBox = new ListBox();
            panel4 = new Panel();
            reportedIssuesListBox = new ListBox();
            panel7 = new Panel();
            panel11 = new Panel();
            updateStatusButton = new Button();
            panel10 = new Panel();
            addRepairActionButton = new Button();
            backButton = new Button();
            continueButton = new Button();
            twigTicketNumContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // twigTicketNumContainer
            // 
            twigTicketNumContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            twigTicketNumContainer.Controls.Add(panel12);
            twigTicketNumContainer.Controls.Add(panel8);
            twigTicketNumContainer.Dock = DockStyle.Top;
            twigTicketNumContainer.Location = new Point(0, 0);
            twigTicketNumContainer.Name = "twigTicketNumContainer";
            twigTicketNumContainer.Padding = new Padding(10, 10, 10, 5);
            twigTicketNumContainer.Size = new Size(931, 122);
            twigTicketNumContainer.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.Controls.Add(comboBox1);
            panel12.Controls.Add(label5);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(10, 64);
            panel12.Name = "panel12";
            panel12.Size = new Size(911, 54);
            panel12.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(391, 0);
            comboBox1.MaximumSize = new Size(500, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(500, 45);
            comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 10, 10);
            label5.Size = new Size(391, 51);
            label5.TabIndex = 0;
            label5.Text = "Staff Performing Repair: ";
            // 
            // panel8
            // 
            panel8.Controls.Add(twigTicketNumberDropDown);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(10, 10);
            panel8.Name = "panel8";
            panel8.Size = new Size(911, 54);
            panel8.TabIndex = 4;
            // 
            // twigTicketNumberDropDown
            // 
            twigTicketNumberDropDown.Dock = DockStyle.Left;
            twigTicketNumberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberDropDown.FormattingEnabled = true;
            twigTicketNumberDropDown.Location = new Point(390, 0);
            twigTicketNumberDropDown.MaximumSize = new Size(500, 0);
            twigTicketNumberDropDown.Name = "twigTicketNumberDropDown";
            twigTicketNumberDropDown.Size = new Size(500, 45);
            twigTicketNumberDropDown.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 47, 10);
            label1.Size = new Size(390, 51);
            label1.TabIndex = 0;
            label1.Text = "TWIG Ticket Number: ";
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 122);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 10, 10, 5);
            panel3.Size = new Size(931, 57);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(631, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(127, 51);
            label4.TabIndex = 5;
            label4.Text = "Notes: ";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(555, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(76, 42);
            panel6.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(307, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(248, 51);
            label2.TabIndex = 3;
            label2.Text = "Repair Actions: ";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(269, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(38, 42);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(259, 51);
            label3.TabIndex = 0;
            label3.Text = "Reported Issues:";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(repairActionsListBox);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(reportedIssuesListBox);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(931, 215);
            panel5.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.Controls.Add(notesTextBox);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(642, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(296, 215);
            panel9.TabIndex = 16;
            // 
            // notesTextBox
            // 
            notesTextBox.Dock = DockStyle.Fill;
            notesTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            notesTextBox.Location = new Point(0, 0);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(296, 215);
            notesTextBox.TabIndex = 0;
            notesTextBox.Text = "";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(631, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 215);
            panel2.TabIndex = 3;
            // 
            // repairActionsListBox
            // 
            repairActionsListBox.Dock = DockStyle.Left;
            repairActionsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            repairActionsListBox.FormattingEnabled = true;
            repairActionsListBox.ItemHeight = 32;
            repairActionsListBox.Location = new Point(324, 0);
            repairActionsListBox.Name = "repairActionsListBox";
            repairActionsListBox.Size = new Size(307, 215);
            repairActionsListBox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(307, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(17, 215);
            panel4.TabIndex = 1;
            // 
            // reportedIssuesListBox
            // 
            reportedIssuesListBox.Dock = DockStyle.Left;
            reportedIssuesListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            reportedIssuesListBox.FormattingEnabled = true;
            reportedIssuesListBox.ItemHeight = 32;
            reportedIssuesListBox.Location = new Point(0, 0);
            reportedIssuesListBox.Name = "reportedIssuesListBox";
            reportedIssuesListBox.Size = new Size(307, 215);
            reportedIssuesListBox.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(panel10);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 394);
            panel7.Name = "panel7";
            panel7.Size = new Size(931, 63);
            panel7.TabIndex = 22;
            // 
            // panel11
            // 
            panel11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel11.Controls.Add(updateStatusButton);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(500, 0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(2);
            panel11.Size = new Size(447, 63);
            panel11.TabIndex = 16;
            // 
            // updateStatusButton
            // 
            updateStatusButton.AutoSize = true;
            updateStatusButton.Dock = DockStyle.Fill;
            updateStatusButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateStatusButton.Location = new Point(2, 2);
            updateStatusButton.Name = "updateStatusButton";
            updateStatusButton.Padding = new Padding(3);
            updateStatusButton.Size = new Size(443, 59);
            updateStatusButton.TabIndex = 18;
            updateStatusButton.Text = "Update Status ";
            updateStatusButton.UseVisualStyleBackColor = true;
            updateStatusButton.Click += updateStatusButton_Click;
            // 
            // panel10
            // 
            panel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel10.Controls.Add(addRepairActionButton);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(3);
            panel10.Size = new Size(500, 63);
            panel10.TabIndex = 15;
            // 
            // addRepairActionButton
            // 
            addRepairActionButton.AutoSize = true;
            addRepairActionButton.Dock = DockStyle.Fill;
            addRepairActionButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addRepairActionButton.Location = new Point(3, 3);
            addRepairActionButton.Name = "addRepairActionButton";
            addRepairActionButton.Size = new Size(494, 57);
            addRepairActionButton.TabIndex = 17;
            addRepairActionButton.Text = "Add Repair Action ";
            addRepairActionButton.UseVisualStyleBackColor = true;
            addRepairActionButton.Click += addRepairActionButton_Click_2;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(581, 457);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 50);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 54);
            backButton.TabIndex = 24;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(756, 457);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 50);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 54);
            continueButton.TabIndex = 23;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click_1;
            // 
            // BrmRepairActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(931, 511);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(twigTicketNumContainer);
            Name = "BrmRepairActionForm";
            Text = "BrmRepairActionForm";
            twigTicketNumContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel twigTicketNumContainer;
        private Panel panel3;
        private Label label4;
        private Panel panel6;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Panel panel5;
        private ListBox repairActionsListBox;
        private Panel panel4;
        private ListBox reportedIssuesListBox;
        private Panel panel2;
        private Panel panel9;
        private RichTextBox notesTextBox;
        private Button button3;
        private Button button1;
        private Panel panel7;
        private Panel panel11;
        private Button updateStatusButton;
        private Panel panel10;
        private Button addRepairActionButton;
        private Button backButton;
        private Button continueButton;
        private Panel panel8;
        private ComboBox twigTicketNumberDropDown;
        private Label label1;
        private Panel panel12;
        private ComboBox comboBox1;
        private Label label5;
    }
}