namespace BatteryRepairModule.Forms.Add_Forms
{
    partial class addTestForm
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
            listBox1 = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            listBox2 = new ListBox();
            label3 = new Label();
            panel5 = new Panel();
            cancelButton = new Button();
            panel6 = new Panel();
            addSelectedTest = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(213, 30);
            label1.TabIndex = 1;
            label1.Text = "Add Required Tests: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(800, 239);
            panel2.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 10);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 2, 2, 2);
            panel4.Size = new Size(395, 219);
            panel4.TabIndex = 23;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(10, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(383, 175);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 2);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(157, 40);
            label2.TabIndex = 1;
            label2.Text = "Test Options: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(listBox2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(395, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2);
            panel3.Size = new Size(395, 219);
            panel3.TabIndex = 22;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 32;
            listBox2.Location = new Point(2, 42);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(391, 175);
            listBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 2);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(153, 40);
            label3.TabIndex = 1;
            label3.Text = "Added Tests: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(cancelButton);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 285);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(2);
            panel5.Size = new Size(406, 126);
            panel5.TabIndex = 22;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Padding = new Padding(10);
            cancelButton.Size = new Size(402, 122);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(addSelectedTest);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(406, 285);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(2);
            panel6.Size = new Size(394, 126);
            panel6.TabIndex = 23;
            // 
            // addSelectedTest
            // 
            addSelectedTest.Dock = DockStyle.Fill;
            addSelectedTest.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addSelectedTest.Location = new Point(2, 2);
            addSelectedTest.Name = "addSelectedTest";
            addSelectedTest.Padding = new Padding(10);
            addSelectedTest.Size = new Size(390, 122);
            addSelectedTest.TabIndex = 14;
            addSelectedTest.Text = "Add Selected Test";
            addSelectedTest.UseVisualStyleBackColor = true;
            addSelectedTest.Click += addSelectedTest_Click;
            // 
            // addTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 450);
            MinimumSize = new Size(816, 389);
            Name = "addTestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addTestForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private ListBox listBox1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private ListBox listBox2;
        private Panel panel5;
        private Button cancelButton;
        private Panel panel6;
        private Button addSelectedTest;
    }
}