using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class serviceInspectionFirstForm
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
            comboBox2 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            panel1 = new Panel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            panel3 = new Panel();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            label4 = new Label();
            continueButton = new Button();
            backButton = new Button();
            twigTicketNumContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // twigTicketNumContainer
            // 
            twigTicketNumContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            twigTicketNumContainer.Controls.Add(comboBox2);
            twigTicketNumContainer.Controls.Add(label1);
            twigTicketNumContainer.Dock = DockStyle.Top;
            twigTicketNumContainer.Location = new Point(0, 0);
            twigTicketNumContainer.Name = "twigTicketNumContainer";
            twigTicketNumContainer.Padding = new Padding(10, 10, 10, 5);
            twigTicketNumContainer.Size = new Size(880, 80);
            twigTicketNumContainer.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(363, 10);
            comboBox2.MaximumSize = new Size(500, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(500, 45);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 10);
            label1.Size = new Size(353, 51);
            label1.TabIndex = 0;
            label1.Text = "TWIG Ticket Number: ";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 5);
            panel2.Size = new Size(880, 80);
            panel2.TabIndex = 3;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Dock = DockStyle.Left;
            radioButton3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(562, 10);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(20, 0, 20, 0);
            radioButton3.Size = new Size(241, 65);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Does not apply ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Left;
            radioButton2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(417, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(20, 0, 20, 0);
            radioButton2.Size = new Size(145, 65);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Unsafe";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Left;
            radioButton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(299, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(20, 0, 20, 0);
            radioButton1.Size = new Size(118, 65);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Safe";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 25, 10);
            label3.Size = new Size(289, 51);
            label3.TabIndex = 0;
            label3.Text = "Verify Shipping: ";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 10, 10, 5);
            panel1.Size = new Size(537, 261);
            panel1.TabIndex = 4;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Dock = DockStyle.Top;
            checkBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(248, 186);
            checkBox5.Name = "checkBox5";
            checkBox5.Padding = new Padding(0, 0, 0, 8);
            checkBox5.Size = new Size(279, 44);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Missing Wires";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Dock = DockStyle.Top;
            checkBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(248, 142);
            checkBox4.Name = "checkBox4";
            checkBox4.Padding = new Padding(0, 0, 0, 8);
            checkBox4.Size = new Size(279, 44);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Housing dents / holes";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Dock = DockStyle.Top;
            checkBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(248, 98);
            checkBox3.Name = "checkBox3";
            checkBox3.Padding = new Padding(0, 0, 0, 8);
            checkBox3.Size = new Size(279, 44);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Screws missing";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Dock = DockStyle.Top;
            checkBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(248, 54);
            checkBox2.Name = "checkBox2";
            checkBox2.Padding = new Padding(0, 0, 0, 8);
            checkBox2.Size = new Size(279, 44);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Evidence of tampering";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Top;
            checkBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(248, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(0, 0, 0, 8);
            checkBox1.Size = new Size(279, 44);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Housing Scrapes";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 25, 10);
            label2.Size = new Size(238, 47);
            label2.TabIndex = 0;
            label2.Text = "Check Battery:";
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton7);
            panel3.Controls.Add(radioButton6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 261);
            panel3.TabIndex = 5;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Dock = DockStyle.Top;
            radioButton7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton7.Location = new Point(537, 83);
            radioButton7.Name = "radioButton7";
            radioButton7.Padding = new Padding(20, 0, 20, 0);
            radioButton7.Size = new Size(343, 36);
            radioButton7.TabIndex = 10;
            radioButton7.TabStop = true;
            radioButton7.Text = "No";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Dock = DockStyle.Top;
            radioButton6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton6.Location = new Point(537, 47);
            radioButton6.Name = "radioButton6";
            radioButton6.Padding = new Padding(20, 0, 20, 0);
            radioButton6.Size = new Size(343, 36);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "Yes";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label4.Location = new Point(537, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 25, 10);
            label4.Size = new Size(376, 47);
            label4.TabIndex = 5;
            label4.Text = "Battery Leads Protected: ";
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 421);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 7;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += button1_Click;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(530, 421);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
            backButton.TabIndex = 8;
            backButton.Text = "Back ";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // serviceInspectionFirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 556);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(twigTicketNumContainer);
            MinimumSize = new Size(0, 530);
            Name = "serviceInspectionFirstForm";
            Text = "serviceInspectionFirstForm";
            twigTicketNumContainer.ResumeLayout(false);
            twigTicketNumContainer.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel twigTicketNumContainer;
        private Label label1;
        private ComboBox comboBox2;
        private Panel panel2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Panel panel1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Panel panel3;
        public Label label4;
        private Button continueButton;
        private Button backButton;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
    }
}