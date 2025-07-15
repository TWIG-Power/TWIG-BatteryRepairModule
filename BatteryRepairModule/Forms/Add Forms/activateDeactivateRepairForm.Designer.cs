namespace BatteryRepairModule.Forms.Add_Forms
{
    partial class activateDeactivateRepairForm
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
            listBox1 = new ListBox();
            panel2 = new Panel();
            panel4 = new Panel();
            continueButton = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(10, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(614, 322);
            listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 119);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(continueButton);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(631, 119);
            panel4.TabIndex = 1;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Fill;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(10, 10);
            continueButton.MaximumSize = new Size(0, 70);
            continueButton.Name = "continueButton";
            continueButton.Padding = new Padding(10);
            continueButton.Size = new Size(611, 70);
            continueButton.TabIndex = 14;
            continueButton.Text = "Activate / Deactivate";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(634, 342);
            panel1.TabIndex = 2;
            // 
            // activateDeactivateRepairForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(650, 500);
            MinimumSize = new Size(650, 500);
            Name = "activateDeactivateRepairForm";
            Text = "activateDeactivateRepairForm";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel2;
        private Panel panel4;
        private Button continueButton;
        private Panel panel1;
    }
}