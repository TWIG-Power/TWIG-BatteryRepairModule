using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class BrmAuthorizeRepairsForm
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
            panel6 = new Panel();
            staffDropDown = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            twigTicketNumberDropDown = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            authorizedRepairsListBox = new ListBox();
            panel2 = new Panel();
            suggestedRepairsListBox = new ListBox();
            panel4 = new Panel();
            reportedIssuesListBox = new ListBox();
            panel9 = new Panel();
            panel11 = new Panel();
            removeAuthorizedRepairAction = new Button();
            panel10 = new Panel();
            addAuthorizedRepairAction = new Button();
            backButton = new Button();
            continueButton = new Button();
            addTestButton = new Button();
            panel12 = new Panel();
            twigTicketNumContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // twigTicketNumContainer
            // 
            twigTicketNumContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            twigTicketNumContainer.Controls.Add(panel6);
            twigTicketNumContainer.Controls.Add(panel1);
            twigTicketNumContainer.Dock = DockStyle.Top;
            twigTicketNumContainer.Location = new Point(0, 0);
            twigTicketNumContainer.Name = "twigTicketNumContainer";
            twigTicketNumContainer.Padding = new Padding(10, 10, 10, 5);
            twigTicketNumContainer.Size = new Size(931, 115);
            twigTicketNumContainer.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(staffDropDown);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 64);
            panel6.Name = "panel6";
            panel6.Size = new Size(911, 54);
            panel6.TabIndex = 4;
            // 
            // staffDropDown
            // 
            staffDropDown.Dock = DockStyle.Left;
            staffDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            staffDropDown.FormattingEnabled = true;
            staffDropDown.Location = new Point(353, 0);
            staffDropDown.MaximumSize = new Size(500, 0);
            staffDropDown.Name = "staffDropDown";
            staffDropDown.Size = new Size(500, 45);
            staffDropDown.TabIndex = 2;
            staffDropDown.SelectedIndexChanged += staffDropDown_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 65, 10);
            label4.Size = new Size(353, 51);
            label4.TabIndex = 0;
            label4.Text = "Staff Authorizing: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(twigTicketNumberDropDown);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 54);
            panel1.TabIndex = 3;
            // 
            // twigTicketNumberDropDown
            // 
            twigTicketNumberDropDown.Dock = DockStyle.Left;
            twigTicketNumberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberDropDown.FormattingEnabled = true;
            twigTicketNumberDropDown.Location = new Point(353, 0);
            twigTicketNumberDropDown.MaximumSize = new Size(500, 0);
            twigTicketNumberDropDown.Name = "twigTicketNumberDropDown";
            twigTicketNumberDropDown.Size = new Size(500, 45);
            twigTicketNumberDropDown.TabIndex = 2;
            twigTicketNumberDropDown.SelectedIndexChanged += twigTicketNumberDropDown_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 10);
            label1.Size = new Size(353, 51);
            label1.TabIndex = 0;
            label1.Text = "TWIG Ticket Number: ";
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2);
            panel3.Size = new Size(931, 57);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(611, 2);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(259, 52);
            label2.TabIndex = 9;
            label2.Text = "Authorized Repairs:";
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(560, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(51, 53);
            panel8.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(302, 2);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(258, 52);
            label5.TabIndex = 7;
            label5.Text = "Suggested Repairs: ";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(232, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(70, 53);
            panel7.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 2);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(230, 52);
            label3.TabIndex = 0;
            label3.Text = "Reported Issues: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(authorizedRepairsListBox);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(suggestedRepairsListBox);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(reportedIssuesListBox);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 172);
            panel5.Name = "panel5";
            panel5.Size = new Size(931, 211);
            panel5.TabIndex = 11;
            // 
            // authorizedRepairsListBox
            // 
            authorizedRepairsListBox.Dock = DockStyle.Left;
            authorizedRepairsListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorizedRepairsListBox.FormattingEnabled = true;
            authorizedRepairsListBox.ItemHeight = 30;
            authorizedRepairsListBox.Location = new Point(634, 0);
            authorizedRepairsListBox.Name = "authorizedRepairsListBox";
            authorizedRepairsListBox.Size = new Size(294, 211);
            authorizedRepairsListBox.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(611, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(23, 211);
            panel2.TabIndex = 3;
            // 
            // suggestedRepairsListBox
            // 
            suggestedRepairsListBox.Dock = DockStyle.Left;
            suggestedRepairsListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            suggestedRepairsListBox.FormattingEnabled = true;
            suggestedRepairsListBox.ItemHeight = 30;
            suggestedRepairsListBox.Location = new Point(315, 0);
            suggestedRepairsListBox.Name = "suggestedRepairsListBox";
            suggestedRepairsListBox.Size = new Size(296, 211);
            suggestedRepairsListBox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(292, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(23, 211);
            panel4.TabIndex = 1;
            // 
            // reportedIssuesListBox
            // 
            reportedIssuesListBox.Dock = DockStyle.Left;
            reportedIssuesListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            reportedIssuesListBox.FormattingEnabled = true;
            reportedIssuesListBox.ItemHeight = 30;
            reportedIssuesListBox.Location = new Point(0, 0);
            reportedIssuesListBox.Name = "reportedIssuesListBox";
            reportedIssuesListBox.Size = new Size(292, 211);
            reportedIssuesListBox.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 383);
            panel9.Name = "panel9";
            panel9.Size = new Size(931, 63);
            panel9.TabIndex = 14;
            // 
            // panel11
            // 
            panel11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel11.Controls.Add(removeAuthorizedRepairAction);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(500, 0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(2);
            panel11.Size = new Size(465, 63);
            panel11.TabIndex = 16;
            // 
            // removeAuthorizedRepairAction
            // 
            removeAuthorizedRepairAction.AutoSize = true;
            removeAuthorizedRepairAction.Dock = DockStyle.Fill;
            removeAuthorizedRepairAction.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeAuthorizedRepairAction.Location = new Point(2, 2);
            removeAuthorizedRepairAction.Name = "removeAuthorizedRepairAction";
            removeAuthorizedRepairAction.Padding = new Padding(3);
            removeAuthorizedRepairAction.Size = new Size(461, 59);
            removeAuthorizedRepairAction.TabIndex = 18;
            removeAuthorizedRepairAction.Text = "Remove Authorized Repair Action";
            removeAuthorizedRepairAction.UseVisualStyleBackColor = true;
            removeAuthorizedRepairAction.Click += removeAuthorizedRepairAction_Click;
            // 
            // panel10
            // 
            panel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel10.Controls.Add(addAuthorizedRepairAction);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(3);
            panel10.Size = new Size(500, 63);
            panel10.TabIndex = 15;
            // 
            // addAuthorizedRepairAction
            // 
            addAuthorizedRepairAction.AutoSize = true;
            addAuthorizedRepairAction.Dock = DockStyle.Fill;
            addAuthorizedRepairAction.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addAuthorizedRepairAction.Location = new Point(3, 3);
            addAuthorizedRepairAction.Name = "addAuthorizedRepairAction";
            addAuthorizedRepairAction.Size = new Size(494, 57);
            addAuthorizedRepairAction.TabIndex = 17;
            addAuthorizedRepairAction.Text = "Add Authorized Repair Action";
            addAuthorizedRepairAction.UseVisualStyleBackColor = true;
            addAuthorizedRepairAction.Click += addAuthorizedRepairAction_Click;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(581, 446);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 40);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 62);
            backButton.TabIndex = 16;
            backButton.Text = "Back ";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click; 
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(756, 446);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 50);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 62);
            continueButton.TabIndex = 15;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // addTestButton
            // 
            addTestButton.AutoSize = true;
            addTestButton.Dock = DockStyle.Fill;
            addTestButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addTestButton.Location = new Point(3, 3);
            addTestButton.MinimumSize = new Size(175, 40);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(494, 56);
            addTestButton.TabIndex = 17;
            addTestButton.Text = "Add Required Test";
            addTestButton.UseVisualStyleBackColor = true;
            addTestButton.Click += addTestButton_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(addTestButton);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 446);
            panel12.MaximumSize = new Size(500, 62);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(3);
            panel12.Size = new Size(500, 62);
            panel12.TabIndex = 18;
            // 
            // BrmAuthorizeRepairsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(931, 511);
            Controls.Add(panel12);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(twigTicketNumContainer);
            Name = "BrmAuthorizeRepairsForm";
            Padding = new Padding(0, 0, 0, 3);
            Text = "BrmAuthorizeRepairsForm";
            twigTicketNumContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel twigTicketNumContainer;
        private ComboBox twigTicketNumberDropDown;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel5;
        private ListBox authorizedRepairsListBox;
        private Panel panel2;
        private ListBox suggestedRepairsListBox;
        private ListBox reportedIssuesListBox;
        private Label label2;
        private Panel panel8;
        private Label label5;
        private Panel panel7;
        private Panel panel9;
        private Panel panel11;
        private Button removeAuthorizedRepairAction;
        private Panel panel10;
        private Button addAuthorizedRepairAction;
        private Button backButton;
        private Button continueButton;
        private Panel panel4;
        private Panel panel1;
        private Panel panel6;
        private ComboBox staffDropDown;
        private Label label4;
        private Button addTestButton;
        private Panel panel12;
    }
}