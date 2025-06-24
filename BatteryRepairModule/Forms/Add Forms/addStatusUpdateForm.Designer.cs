namespace BatteryRepairModule.Forms.Add_Forms
{
    partial class addStatusUpdateForm
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
            listBox1 = new ListBox();
            panel2 = new Panel();
            panel4 = new Panel();
            continueButton = new Button();
            panel3 = new Panel();
            cancelButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(374, 342);
            panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(10, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 322);
            listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 119);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(continueButton);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(188, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(176, 119);
            panel4.TabIndex = 1;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Fill;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(10, 10);
            continueButton.MaximumSize = new Size(175, 70);
            continueButton.Name = "continueButton";
            continueButton.Padding = new Padding(10);
            continueButton.Size = new Size(156, 70);
            continueButton.TabIndex = 14;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(cancelButton);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(188, 119);
            panel3.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(10, 10);
            cancelButton.MaximumSize = new Size(175, 70);
            cancelButton.Name = "cancelButton";
            cancelButton.Padding = new Padding(10);
            cancelButton.Size = new Size(168, 70);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addStatusUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addStatusUpdateForm";
            Text = "addStatusUpdateForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private Panel panel2;
        private Panel panel4;
        private Button continueButton;
        private Panel panel3;
        private Button cancelButton;
    }
}