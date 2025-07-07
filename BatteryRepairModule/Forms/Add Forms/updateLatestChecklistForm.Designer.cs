namespace BatteryRepairModule.Forms.Add_Forms
{
    partial class updateLatestChecklistForm
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
            label1 = new Label();
            panel2 = new Panel();
            twigTicketNumberDropDown = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            attachFileButton = new Button();
            qualityChecklistPathTextBox = new MaskedTextBox();
            label2 = new Label();
            cancelButton = new Button();
            submitButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 1;
            label1.Text = "Update Latest Quality Checklist: ";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(twigTicketNumberDropDown);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(800, 80);
            panel2.TabIndex = 11;
            // 
            // twigTicketNumberDropDown
            // 
            twigTicketNumberDropDown.Dock = DockStyle.Fill;
            twigTicketNumberDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            twigTicketNumberDropDown.FormattingEnabled = true;
            twigTicketNumberDropDown.Location = new Point(269, 20);
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
            label4.Size = new Size(249, 41);
            label4.TabIndex = 0;
            label4.Text = "Module Type: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(attachFileButton);
            panel3.Controls.Add(qualityChecklistPathTextBox);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 10, 10, 5);
            panel3.Size = new Size(800, 88);
            panel3.TabIndex = 13;
            // 
            // attachFileButton
            // 
            attachFileButton.Dock = DockStyle.Left;
            attachFileButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            attachFileButton.Location = new Point(697, 10);
            attachFileButton.Name = "attachFileButton";
            attachFileButton.Size = new Size(103, 73);
            attachFileButton.TabIndex = 4;
            attachFileButton.Text = "Attach";
            attachFileButton.UseVisualStyleBackColor = true;
            attachFileButton.Click += attachFileButton_Click;
            // 
            // qualityChecklistPathTextBox
            // 
            qualityChecklistPathTextBox.Dock = DockStyle.Left;
            qualityChecklistPathTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            qualityChecklistPathTextBox.Location = new Point(197, 10);
            qualityChecklistPathTextBox.MaximumSize = new Size(500, 0);
            qualityChecklistPathTextBox.MinimumSize = new Size(0, 110);
            qualityChecklistPathTextBox.Name = "qualityChecklistPathTextBox";
            qualityChecklistPathTextBox.Size = new Size(500, 110);
            qualityChecklistPathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 40, 0);
            label2.Size = new Size(187, 41);
            label2.TabIndex = 0;
            label2.Text = "File Path:";
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(530, 220);
            cancelButton.MaximumSize = new Size(1355, 60);
            cancelButton.MinimumSize = new Size(135, 60);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(135, 60);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Dock = DockStyle.Right;
            submitButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(665, 220);
            submitButton.MaximumSize = new Size(1355, 60);
            submitButton.MinimumSize = new Size(135, 60);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(135, 60);
            submitButton.TabIndex = 14;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // updateLatestChecklistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 288);
            Controls.Add(cancelButton);
            Controls.Add(submitButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "updateLatestChecklistForm";
            Text = "updateLatestChecklistForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox twigTicketNumberDropDown;
        private Label label4;
        private Panel panel3;
        private Button attachFileButton;
        private MaskedTextBox qualityChecklistPathTextBox;
        private Label label2;
        private Button cancelButton;
        private Button submitButton;
    }
}