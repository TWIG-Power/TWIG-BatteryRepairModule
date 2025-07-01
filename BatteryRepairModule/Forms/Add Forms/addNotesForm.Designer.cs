namespace BatteryRepairModule.Forms.Add_Forms
{
    partial class addNotesForm
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
            cancelButton = new Button();
            continueButton = new Button();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(450, 185);
            cancelButton.MaximumSize = new Size(175, 80);
            cancelButton.MinimumSize = new Size(175, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 80);
            cancelButton.TabIndex = 22;
            cancelButton.Text = "Back";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(625, 185);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 21;
            continueButton.Text = "Continue ";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(800, 133);
            panel2.TabIndex = 20;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(10, 10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(780, 113);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 1;
            label1.Text = "Add Notes to selected repair: ";
            // 
            // addNotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 264);
            Controls.Add(cancelButton);
            Controls.Add(continueButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimumSize = new Size(816, 303);
            Name = "addNotesForm";
            Text = "addNotesForm";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelButton;
        private Button continueButton;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label label1;
    }
}