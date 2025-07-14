namespace BatteryRepairModule.Forms.Service_Inspection_Forms
{
    partial class serviceInspectionForm2
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
            panel7 = new Panel();
            panel10 = new Panel();
            repairCompletedButton = new Button();
            panel8 = new Panel();
            addRepairActionButton = new Button();
            panel5 = new Panel();
            repairActionsListBox = new ListBox();
            panel4 = new Panel();
            reportedIssuesListBox = new ListBox();
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            backButton = new Button();
            continueButton = new Button();
            panel2 = new Panel();
            activateReactiveRepair = new Button();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 353);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(2);
            panel7.Size = new Size(931, 75);
            panel7.TabIndex = 22;
            // 
            // panel10
            // 
            panel10.Controls.Add(repairCompletedButton);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(464, 2);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(5);
            panel10.Size = new Size(444, 71);
            panel10.TabIndex = 20;
            // 
            // repairCompletedButton
            // 
            repairCompletedButton.AutoSize = true;
            repairCompletedButton.Dock = DockStyle.Fill;
            repairCompletedButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            repairCompletedButton.Location = new Point(5, 5);
            repairCompletedButton.Name = "repairCompletedButton";
            repairCompletedButton.Size = new Size(434, 61);
            repairCompletedButton.TabIndex = 18;
            repairCompletedButton.Text = "Remove Repair Action";
            repairCompletedButton.UseVisualStyleBackColor = true;
            repairCompletedButton.Click += repairCompletedButton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(addRepairActionButton);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(2, 2);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(462, 71);
            panel8.TabIndex = 19;
            // 
            // addRepairActionButton
            // 
            addRepairActionButton.AutoSize = true;
            addRepairActionButton.Dock = DockStyle.Fill;
            addRepairActionButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addRepairActionButton.Location = new Point(5, 5);
            addRepairActionButton.Name = "addRepairActionButton";
            addRepairActionButton.Size = new Size(452, 61);
            addRepairActionButton.TabIndex = 17;
            addRepairActionButton.Text = "Add Repair Action";
            addRepairActionButton.UseVisualStyleBackColor = true;
            addRepairActionButton.Click += addRepairActionButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(repairActionsListBox);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(reportedIssuesListBox);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 84);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(931, 269);
            panel5.TabIndex = 21;
            // 
            // repairActionsListBox
            // 
            repairActionsListBox.Dock = DockStyle.Left;
            repairActionsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            repairActionsListBox.FormattingEnabled = true;
            repairActionsListBox.ItemHeight = 32;
            repairActionsListBox.Location = new Point(475, 5);
            repairActionsListBox.Name = "repairActionsListBox";
            repairActionsListBox.Size = new Size(439, 259);
            repairActionsListBox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(444, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(31, 259);
            panel4.TabIndex = 1;
            // 
            // reportedIssuesListBox
            // 
            reportedIssuesListBox.Dock = DockStyle.Left;
            reportedIssuesListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            reportedIssuesListBox.FormattingEnabled = true;
            reportedIssuesListBox.ItemHeight = 32;
            reportedIssuesListBox.Location = new Point(5, 5);
            reportedIssuesListBox.Name = "reportedIssuesListBox";
            reportedIssuesListBox.Size = new Size(439, 259);
            reportedIssuesListBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(931, 84);
            panel3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 15);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(258, 61);
            label2.TabIndex = 3;
            label2.Text = "Repair Actions: ";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(284, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 54);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(269, 61);
            label3.TabIndex = 0;
            label3.Text = "Reported Issues:";
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(581, 428);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
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
            continueButton.Location = new Point(756, 428);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 23;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(activateReactiveRepair);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 428);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(7, 10, 7, 10);
            panel2.Size = new Size(462, 83);
            panel2.TabIndex = 25;
            // 
            // activateReactiveRepair
            // 
            activateReactiveRepair.AutoSize = true;
            activateReactiveRepair.Dock = DockStyle.Fill;
            activateReactiveRepair.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            activateReactiveRepair.Location = new Point(7, 10);
            activateReactiveRepair.MaximumSize = new Size(0, 63);
            activateReactiveRepair.Name = "activateReactiveRepair";
            activateReactiveRepair.Size = new Size(448, 63);
            activateReactiveRepair.TabIndex = 17;
            activateReactiveRepair.Text = "Activate / Deactivate Repair";
            activateReactiveRepair.UseVisualStyleBackColor = true;
            activateReactiveRepair.Click += activateReactiveRepair_Click;
            // 
            // serviceInspectionForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(931, 511);
            Controls.Add(panel2);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "serviceInspectionForm2";
            Text = "serviceInspectionForm2";
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Panel panel10;
        private Button repairCompletedButton;
        private Panel panel8;
        private Button addRepairActionButton;
        private Panel panel5;
        private ListBox repairActionsListBox;
        private Panel panel4;
        private ListBox reportedIssuesListBox;
        private Panel panel3;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Button backButton;
        private Button continueButton;
        private Panel panel2;
        private Button activateReactiveRepair;
    }
}