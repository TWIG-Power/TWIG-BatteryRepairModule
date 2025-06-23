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
            backButton = new Button();
            continueButton = new Button();
            addRepairActionButton = new Button();
            panel7 = new Panel();
            panel10 = new Panel();
            repairCompletedButton = new Button();
            panel8 = new Panel();
            twigTicketNumContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // twigTicketNumContainer
            // 
            twigTicketNumContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            twigTicketNumContainer.Controls.Add(twigTicketNumberDropDown);
            twigTicketNumContainer.Controls.Add(label1);
            twigTicketNumContainer.Dock = DockStyle.Top;
            twigTicketNumContainer.Location = new Point(0, 0);
            twigTicketNumContainer.Name = "twigTicketNumContainer";
            twigTicketNumContainer.Padding = new Padding(10, 10, 10, 5);
            twigTicketNumContainer.Size = new Size(880, 80);
            twigTicketNumContainer.TabIndex = 3;
            // 
            // twigTicketNumberDropDown
            // 
            twigTicketNumberDropDown.Dock = DockStyle.Fill;
            twigTicketNumberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberDropDown.FormattingEnabled = true;
            twigTicketNumberDropDown.Location = new Point(363, 10);
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
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 10);
            label1.Size = new Size(353, 51);
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
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 10, 10, 5);
            panel3.Size = new Size(880, 80);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(583, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(137, 61);
            label4.TabIndex = 5;
            label4.Text = "Notes: ";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(555, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(28, 65);
            panel6.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(297, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(258, 61);
            label2.TabIndex = 3;
            label2.Text = "Repair Actions: ";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(279, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 65);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(269, 61);
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
            panel5.Location = new Point(0, 160);
            panel5.Name = "panel5";
            panel5.Size = new Size(880, 213);
            panel5.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.Controls.Add(notesTextBox);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(594, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(286, 213);
            panel9.TabIndex = 16;
            // 
            // notesTextBox
            // 
            notesTextBox.Dock = DockStyle.Left;
            notesTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            notesTextBox.Location = new Point(0, 0);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(286, 213);
            notesTextBox.TabIndex = 0;
            notesTextBox.Text = "";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(583, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 213);
            panel2.TabIndex = 3;
            // 
            // repairActionsListBox
            // 
            repairActionsListBox.Dock = DockStyle.Left;
            repairActionsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            repairActionsListBox.FormattingEnabled = true;
            repairActionsListBox.ItemHeight = 32;
            repairActionsListBox.Location = new Point(300, 0);
            repairActionsListBox.Name = "repairActionsListBox";
            repairActionsListBox.Size = new Size(283, 213);
            repairActionsListBox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(283, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(17, 213);
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
            reportedIssuesListBox.Size = new Size(283, 213);
            reportedIssuesListBox.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(530, 474);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
            backButton.TabIndex = 21;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 474);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 20;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            // 
            // addRepairActionButton
            // 
            addRepairActionButton.AutoSize = true;
            addRepairActionButton.Dock = DockStyle.Fill;
            addRepairActionButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addRepairActionButton.Location = new Point(0, 0);
            addRepairActionButton.Name = "addRepairActionButton";
            addRepairActionButton.Size = new Size(444, 96);
            addRepairActionButton.TabIndex = 17;
            addRepairActionButton.Text = "Add Repair Action";
            addRepairActionButton.UseVisualStyleBackColor = true;
            addRepairActionButton.Click += addRepairActionButton_Click_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 373);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 5, 0, 0);
            panel7.Size = new Size(880, 101);
            panel7.TabIndex = 19;
            // 
            // panel10
            // 
            panel10.Controls.Add(repairCompletedButton);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(444, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(444, 96);
            panel10.TabIndex = 20;
            // 
            // repairCompletedButton
            // 
            repairCompletedButton.AutoSize = true;
            repairCompletedButton.Dock = DockStyle.Fill;
            repairCompletedButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            repairCompletedButton.Location = new Point(0, 0);
            repairCompletedButton.Name = "repairCompletedButton";
            repairCompletedButton.Size = new Size(444, 96);
            repairCompletedButton.TabIndex = 18;
            repairCompletedButton.Text = "Repair Completed";
            repairCompletedButton.UseVisualStyleBackColor = true;
            repairCompletedButton.Click += repairCompletedButton_Click_1;
            // 
            // panel8
            // 
            panel8.Controls.Add(addRepairActionButton);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(444, 96);
            panel8.TabIndex = 19;
            // 
            // BrmRepairActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 556);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(twigTicketNumContainer);
            Name = "BrmRepairActionForm";
            Text = "BrmRepairActionForm";
            twigTicketNumContainer.ResumeLayout(false);
            twigTicketNumContainer.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel twigTicketNumContainer;
        private ComboBox twigTicketNumberDropDown;
        private Label label1;
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
        private Button backButton;
        private Button continueButton;
        private Panel panel7;
        private Panel panel10;
        private Button button1;
        private Panel panel8;
        private Button addRepairActionButton;
        private Button repairCompletedButton;
    }
}