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
            staffDropDown = new ComboBox();
            label5 = new Label();
            panel8 = new Panel();
            twigTicketNumberDropDown = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            reportedIssuesListBox = new ListBox();
            panel4 = new Panel();
            repairActionsListBox = new ListBox();
            panel7 = new Panel();
            panel6 = new Panel();
            updateRepairStatus = new Button();
            panel2 = new Panel();
            addRepairNotesButton = new Button();
            panel11 = new Panel();
            viewRepairNotesButton = new Button();
            panel10 = new Panel();
            addRepairActionButton = new Button();
            panel13 = new Panel();
            panel14 = new Panel();
            clearModuleForTestingButton = new Button();
            panel15 = new Panel();
            panel16 = new Panel();
            addTestButton = new Button();
            panel17 = new Panel();
            updateIssueStatus = new Button();
            twigTicketNumContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
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
            panel12.Controls.Add(staffDropDown);
            panel12.Controls.Add(label5);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(10, 64);
            panel12.Name = "panel12";
            panel12.Size = new Size(911, 54);
            panel12.TabIndex = 5;
            // 
            // staffDropDown
            // 
            staffDropDown.Dock = DockStyle.Left;
            staffDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            staffDropDown.FormattingEnabled = true;
            staffDropDown.Location = new Point(391, 0);
            staffDropDown.MaximumSize = new Size(500, 0);
            staffDropDown.Name = "staffDropDown";
            staffDropDown.Size = new Size(500, 45);
            staffDropDown.TabIndex = 2;
            staffDropDown.SelectedIndexChanged += staffDropDown_SelectedIndexChanged;
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
            twigTicketNumberDropDown.SelectedIndexChanged += twigTicketNumberDropDown_SelectedIndexChanged;
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
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 122);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 10, 10, 5);
            panel3.Size = new Size(931, 57);
            panel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(467, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(248, 51);
            label3.TabIndex = 0;
            label3.Text = "Repair Actions: ";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(261, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 42);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(251, 51);
            label2.TabIndex = 3;
            label2.Text = "Reported Issues";
            // 
            // panel5
            // 
            panel5.Controls.Add(reportedIssuesListBox);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(repairActionsListBox);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 179);
            panel5.MaximumSize = new Size(931, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(931, 215);
            panel5.TabIndex = 12;
            // 
            // reportedIssuesListBox
            // 
            reportedIssuesListBox.Dock = DockStyle.Right;
            reportedIssuesListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            reportedIssuesListBox.FormattingEnabled = true;
            reportedIssuesListBox.ItemHeight = 32;
            reportedIssuesListBox.Location = new Point(0, 0);
            reportedIssuesListBox.Name = "reportedIssuesListBox";
            reportedIssuesListBox.Size = new Size(458, 215);
            reportedIssuesListBox.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(458, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(17, 215);
            panel4.TabIndex = 1;
            // 
            // repairActionsListBox
            // 
            repairActionsListBox.Dock = DockStyle.Right;
            repairActionsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            repairActionsListBox.FormattingEnabled = true;
            repairActionsListBox.ItemHeight = 32;
            repairActionsListBox.Location = new Point(475, 0);
            repairActionsListBox.Name = "repairActionsListBox";
            repairActionsListBox.Size = new Size(456, 215);
            repairActionsListBox.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(panel10);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 394);
            panel7.Name = "panel7";
            panel7.Size = new Size(931, 63);
            panel7.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.Controls.Add(updateRepairStatus);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(695, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(3);
            panel6.Size = new Size(236, 63);
            panel6.TabIndex = 18;
            // 
            // updateRepairStatus
            // 
            updateRepairStatus.AutoSize = true;
            updateRepairStatus.BackColor = Color.LemonChiffon;
            updateRepairStatus.Dock = DockStyle.Fill;
            updateRepairStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updateRepairStatus.Location = new Point(3, 3);
            updateRepairStatus.MinimumSize = new Size(175, 50);
            updateRepairStatus.Name = "updateRepairStatus";
            updateRepairStatus.Size = new Size(230, 57);
            updateRepairStatus.TabIndex = 27;
            updateRepairStatus.Text = "Update Repair Status";
            updateRepairStatus.UseVisualStyleBackColor = false;
            updateRepairStatus.Click += updateRepairStatus_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(addRepairNotesButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(450, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(3);
            panel2.Size = new Size(245, 63);
            panel2.TabIndex = 17;
            // 
            // addRepairNotesButton
            // 
            addRepairNotesButton.AutoSize = true;
            addRepairNotesButton.BackColor = Color.LemonChiffon;
            addRepairNotesButton.Dock = DockStyle.Fill;
            addRepairNotesButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addRepairNotesButton.Location = new Point(3, 3);
            addRepairNotesButton.Name = "addRepairNotesButton";
            addRepairNotesButton.Padding = new Padding(3);
            addRepairNotesButton.Size = new Size(239, 57);
            addRepairNotesButton.TabIndex = 18;
            addRepairNotesButton.Text = "Add Repair Notes";
            addRepairNotesButton.UseVisualStyleBackColor = false;
            addRepairNotesButton.Click += button1_Click;
            // 
            // panel11
            // 
            panel11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel11.Controls.Add(viewRepairNotesButton);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(232, 0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(2);
            panel11.Size = new Size(218, 63);
            panel11.TabIndex = 16;
            // 
            // viewRepairNotesButton
            // 
            viewRepairNotesButton.AutoSize = true;
            viewRepairNotesButton.BackColor = Color.LemonChiffon;
            viewRepairNotesButton.Dock = DockStyle.Fill;
            viewRepairNotesButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewRepairNotesButton.Location = new Point(2, 2);
            viewRepairNotesButton.Name = "viewRepairNotesButton";
            viewRepairNotesButton.Padding = new Padding(3);
            viewRepairNotesButton.Size = new Size(214, 59);
            viewRepairNotesButton.TabIndex = 18;
            viewRepairNotesButton.Text = "View Repair Notes";
            viewRepairNotesButton.UseVisualStyleBackColor = false;
            viewRepairNotesButton.Click += updateStatusButton_Click;
            // 
            // panel10
            // 
            panel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel10.Controls.Add(addRepairActionButton);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(3);
            panel10.Size = new Size(232, 63);
            panel10.TabIndex = 15;
            // 
            // addRepairActionButton
            // 
            addRepairActionButton.AutoSize = true;
            addRepairActionButton.BackColor = Color.LemonChiffon;
            addRepairActionButton.Dock = DockStyle.Fill;
            addRepairActionButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addRepairActionButton.Location = new Point(3, 3);
            addRepairActionButton.Name = "addRepairActionButton";
            addRepairActionButton.Size = new Size(226, 57);
            addRepairActionButton.TabIndex = 17;
            addRepairActionButton.Text = "Add Repair Action ";
            addRepairActionButton.UseVisualStyleBackColor = false;
            addRepairActionButton.Click += addRepairActionButton_Click_2;
            // 
            // panel13
            // 
            panel13.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 457);
            panel13.Name = "panel13";
            panel13.Size = new Size(931, 57);
            panel13.TabIndex = 23;
            // 
            // panel14
            // 
            panel14.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel14.Controls.Add(clearModuleForTestingButton);
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(695, 0);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(3);
            panel14.Size = new Size(236, 57);
            panel14.TabIndex = 18;
            // 
            // clearModuleForTestingButton
            // 
            clearModuleForTestingButton.BackColor = Color.FromArgb(192, 255, 192);
            clearModuleForTestingButton.Dock = DockStyle.Fill;
            clearModuleForTestingButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            clearModuleForTestingButton.Location = new Point(3, 3);
            clearModuleForTestingButton.MinimumSize = new Size(175, 50);
            clearModuleForTestingButton.Name = "clearModuleForTestingButton";
            clearModuleForTestingButton.Size = new Size(230, 51);
            clearModuleForTestingButton.TabIndex = 31;
            clearModuleForTestingButton.Text = "Clear Module For Testing";
            clearModuleForTestingButton.UseVisualStyleBackColor = false;
            clearModuleForTestingButton.Click += clearModuleForTestingButton_Click;
            // 
            // panel15
            // 
            panel15.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(450, 0);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(2);
            panel15.Size = new Size(245, 57);
            panel15.TabIndex = 17;
            // 
            // panel16
            // 
            panel16.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel16.Controls.Add(addTestButton);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(232, 0);
            panel16.Name = "panel16";
            panel16.Padding = new Padding(3);
            panel16.Size = new Size(218, 57);
            panel16.TabIndex = 16;
            // 
            // addTestButton
            // 
            addTestButton.AutoSize = true;
            addTestButton.BackColor = Color.LavenderBlush;
            addTestButton.Dock = DockStyle.Fill;
            addTestButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addTestButton.Location = new Point(3, 3);
            addTestButton.Margin = new Padding(5);
            addTestButton.MinimumSize = new Size(175, 40);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(212, 51);
            addTestButton.TabIndex = 30;
            addTestButton.Text = "Add Required Test";
            addTestButton.UseVisualStyleBackColor = false;
            addTestButton.Click += addTestButton_Click;
            // 
            // panel17
            // 
            panel17.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel17.Controls.Add(updateIssueStatus);
            panel17.Dock = DockStyle.Left;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Padding = new Padding(3);
            panel17.Size = new Size(232, 57);
            panel17.TabIndex = 15;
            // 
            // updateIssueStatus
            // 
            updateIssueStatus.AutoSize = true;
            updateIssueStatus.BackColor = Color.LightCyan;
            updateIssueStatus.Dock = DockStyle.Fill;
            updateIssueStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updateIssueStatus.Location = new Point(3, 3);
            updateIssueStatus.MinimumSize = new Size(175, 50);
            updateIssueStatus.Name = "updateIssueStatus";
            updateIssueStatus.Size = new Size(226, 51);
            updateIssueStatus.TabIndex = 29;
            updateIssueStatus.Text = "Update Issue Status";
            updateIssueStatus.UseVisualStyleBackColor = false;
            updateIssueStatus.Click += continueButton_Click_1;
            // 
            // BrmRepairActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(931, 511);
            Controls.Add(panel13);
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
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel twigTicketNumContainer;
        private Panel panel3;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Panel panel5;
        private ListBox repairActionsListBox;
        private Panel panel4;
        private Button addRepairNotesButton;
        private Panel panel7;
        private Panel panel11;
        private Button viewRepairNotesButton;
        private Panel panel10;
        private Button addRepairActionButton;
        private Panel panel8;
        private ComboBox twigTicketNumberDropDown;
        private Label label1;
        private Panel panel12;
        private ComboBox staffDropDown;
        private Label label5;
        private Panel panel2;
        private Panel panel6;
        private Button updateRepairStatus;
        private Panel panel13;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Button updateIssueStatus;
        private Panel panel14;
        private Button clearModuleForTestingButton;
        private Button addTestButton;
        private ListBox reportedIssuesListBox;
    }
}