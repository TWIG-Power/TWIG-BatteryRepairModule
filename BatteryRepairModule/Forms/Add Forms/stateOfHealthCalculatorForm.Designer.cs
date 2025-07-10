namespace BatteryRepairModule.Forms.Add_Forms
{
    partial class stateOfHealthCalculatorForm
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
            panel4 = new Panel();
            panel8 = new Panel();
            stateOfHealthRangeChangeLabel = new Label();
            label10 = new Label();
            panel3 = new Panel();
            stateOfHealthGradeChangeLabel = new Label();
            label8 = new Label();
            panel7 = new Panel();
            moduleTypeChangeLabel = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            calculateButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            submitButton = new Button();
            cancelButton = new Button();
            panel9 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(825, 52);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(281, 30);
            label1.TabIndex = 1;
            label1.Text = "State Of Health Calculator: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(825, 218);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 108);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(805, 411);
            panel4.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Controls.Add(stateOfHealthRangeChangeLabel);
            panel8.Controls.Add(label10);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(520, 10);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(10);
            panel8.Size = new Size(257, 391);
            panel8.TabIndex = 8;
            // 
            // stateOfHealthRangeChangeLabel
            // 
            stateOfHealthRangeChangeLabel.AutoSize = true;
            stateOfHealthRangeChangeLabel.Dock = DockStyle.Top;
            stateOfHealthRangeChangeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stateOfHealthRangeChangeLabel.Location = new Point(10, 40);
            stateOfHealthRangeChangeLabel.Name = "stateOfHealthRangeChangeLabel";
            stateOfHealthRangeChangeLabel.Size = new Size(47, 30);
            stateOfHealthRangeChangeLabel.TabIndex = 5;
            stateOfHealthRangeChangeLabel.Text = "null";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(10, 10);
            label10.Name = "label10";
            label10.Size = new Size(243, 30);
            label10.TabIndex = 4;
            label10.Text = "State Of Health Range: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(stateOfHealthGradeChangeLabel);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(263, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(257, 391);
            panel3.TabIndex = 7;
            // 
            // stateOfHealthGradeChangeLabel
            // 
            stateOfHealthGradeChangeLabel.AutoSize = true;
            stateOfHealthGradeChangeLabel.Dock = DockStyle.Top;
            stateOfHealthGradeChangeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stateOfHealthGradeChangeLabel.Location = new Point(10, 40);
            stateOfHealthGradeChangeLabel.Name = "stateOfHealthGradeChangeLabel";
            stateOfHealthGradeChangeLabel.Size = new Size(47, 30);
            stateOfHealthGradeChangeLabel.TabIndex = 5;
            stateOfHealthGradeChangeLabel.Text = "null";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 10);
            label8.Name = "label8";
            label8.Size = new Size(239, 30);
            label8.TabIndex = 4;
            label8.Text = "State Of Health Grade: ";
            // 
            // panel7
            // 
            panel7.Controls.Add(moduleTypeChangeLabel);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10);
            panel7.Size = new Size(253, 391);
            panel7.TabIndex = 6;
            // 
            // moduleTypeChangeLabel
            // 
            moduleTypeChangeLabel.AutoSize = true;
            moduleTypeChangeLabel.Dock = DockStyle.Top;
            moduleTypeChangeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            moduleTypeChangeLabel.Location = new Point(10, 40);
            moduleTypeChangeLabel.Name = "moduleTypeChangeLabel";
            moduleTypeChangeLabel.Size = new Size(47, 30);
            moduleTypeChangeLabel.TabIndex = 5;
            moduleTypeChangeLabel.Text = "null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(153, 30);
            label2.TabIndex = 4;
            label2.Text = "Module Type: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(805, 98);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(calculateButton);
            panel6.Controls.Add(maskedTextBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(147, 10);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(648, 70);
            panel6.TabIndex = 7;
            // 
            // calculateButton
            // 
            calculateButton.Dock = DockStyle.Left;
            calculateButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.Location = new Point(488, 10);
            calculateButton.MaximumSize = new Size(1355, 60);
            calculateButton.MinimumSize = new Size(135, 60);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(135, 60);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Dock = DockStyle.Left;
            maskedTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(10, 10);
            maskedTextBox1.MaximumSize = new Size(500, 0);
            maskedTextBox1.MinimumSize = new Size(0, 110);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(478, 110);
            maskedTextBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(137, 30);
            label5.TabIndex = 3;
            label5.Text = "Watt Hours: ";
            // 
            // submitButton
            // 
            submitButton.Dock = DockStyle.Right;
            submitButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(545, 10);
            submitButton.MaximumSize = new Size(1355, 60);
            submitButton.MinimumSize = new Size(135, 60);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(135, 60);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(680, 10);
            cancelButton.MaximumSize = new Size(1355, 60);
            cancelButton.MinimumSize = new Size(135, 60);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(135, 60);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(submitButton);
            panel9.Controls.Add(cancelButton);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 270);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(10);
            panel9.Size = new Size(825, 98);
            panel9.TabIndex = 10;
            // 
            // stateOfHealthCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 372);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(841, 411);
            MinimumSize = new Size(841, 411);
            Name = "stateOfHealthCalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "stateOfHealthCalculatorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button calculateButton;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Panel panel7;
        private Label moduleTypeChangeLabel;
        private Label label2;
        private Button submitButton;
        private Button cancelButton;
        private Panel panel8;
        private Label stateOfHealthRangeChangeLabel;
        private Label label10;
        private Panel panel3;
        private Label stateOfHealthGradeChangeLabel;
        private Label label8;
        private Panel panel9;
    }
}