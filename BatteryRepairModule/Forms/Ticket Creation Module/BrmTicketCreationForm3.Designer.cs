namespace BatteryRepairModule
{
    partial class BrmTicketCreationForm3
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
            panel5 = new Panel();
            label5 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            addedErrorsListBox = new ListBox();
            panel9 = new Panel();
            errorsListBox = new ListBox();
            panel12 = new Panel();
            panel14 = new Panel();
            button2 = new Button();
            panel13 = new Panel();
            button1 = new Button();
            cancelButton = new Button();
            continueButton = new Button();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel12.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(880, 50);
            panel5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(458, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 25, 10);
            label5.Size = new Size(254, 51);
            label5.TabIndex = 6;
            label5.Text = "Added Faults: ";
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(316, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(142, 50);
            panel10.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 25, 10);
            label4.Size = new Size(316, 51);
            label4.TabIndex = 1;
            label4.Text = "Pre-defined faults:";
            // 
            // panel7
            // 
            panel7.Controls.Add(addedErrorsListBox);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(errorsListBox);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(880, 246);
            panel7.TabIndex = 11;
            // 
            // addedErrorsListBox
            // 
            addedErrorsListBox.Dock = DockStyle.Left;
            addedErrorsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addedErrorsListBox.FormattingEnabled = true;
            addedErrorsListBox.ItemHeight = 32;
            addedErrorsListBox.Location = new Point(458, 0);
            addedErrorsListBox.Name = "addedErrorsListBox";
            addedErrorsListBox.Size = new Size(422, 246);
            addedErrorsListBox.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(421, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(37, 246);
            panel9.TabIndex = 4;
            // 
            // errorsListBox
            // 
            errorsListBox.Dock = DockStyle.Left;
            errorsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            errorsListBox.FormattingEnabled = true;
            errorsListBox.ItemHeight = 32;
            errorsListBox.Location = new Point(0, 0);
            errorsListBox.Name = "errorsListBox";
            errorsListBox.Size = new Size(421, 246);
            errorsListBox.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel14);
            panel12.Controls.Add(panel13);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 296);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(10);
            panel12.Size = new Size(880, 95);
            panel12.TabIndex = 13;
            // 
            // panel14
            // 
            panel14.Controls.Add(button2);
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(440, 10);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(5);
            panel14.Size = new Size(430, 75);
            panel14.TabIndex = 1;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(5, 5);
            button2.Name = "button2";
            button2.Size = new Size(420, 65);
            button2.TabIndex = 19;
            button2.Text = "Remove Customer Report";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(button1);
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(10, 10);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(5);
            panel13.Size = new Size(430, 75);
            panel13.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(5, 5);
            button1.Name = "button1";
            button1.Size = new Size(420, 65);
            button1.TabIndex = 18;
            button1.Text = "Add Customer Report";
            button1.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(530, 391);
            cancelButton.MaximumSize = new Size(175, 80);
            cancelButton.MinimumSize = new Size(175, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 80);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 391);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 15;
            continueButton.Text = "Continue ";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // BrmTicketCreationForm3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 491);
            Controls.Add(cancelButton);
            Controls.Add(continueButton);
            Controls.Add(panel12);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Name = "BrmTicketCreationForm3";
            Text = "BrmTicketCreationForm1";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label label5;
        private Panel panel10;
        private Label label4;
        private Panel panel7;
        private ListBox addedErrorsListBox;
        private Panel panel9;
        private ListBox errorsListBox;
        private Panel panel12;
        private Panel panel14;
        private Button button2;
        private Panel panel13;
        private Button button1;
        private Button cancelButton;
        private Button continueButton;
    }
}