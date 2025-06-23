using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class BrmTicketCreationForm2
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
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            cableDamageCheckBox = new CheckBox();
            chargePortCheckBox = new CheckBox();
            panel4 = new Panel();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            label4 = new Label();
            continueButton = new Button();
            cancelButton = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
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
            panel1.Size = new Size(578, 262);
            panel1.TabIndex = 4;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Dock = DockStyle.Top;
            checkBox5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(248, 206);
            checkBox5.Name = "checkBox5";
            checkBox5.Padding = new Padding(0, 0, 0, 8);
            checkBox5.Size = new Size(320, 49);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Missing Wires";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Dock = DockStyle.Top;
            checkBox4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(248, 157);
            checkBox4.Name = "checkBox4";
            checkBox4.Padding = new Padding(0, 0, 0, 8);
            checkBox4.Size = new Size(320, 49);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Housing dents / holes";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Dock = DockStyle.Top;
            checkBox3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(248, 108);
            checkBox3.Name = "checkBox3";
            checkBox3.Padding = new Padding(0, 0, 0, 8);
            checkBox3.Size = new Size(320, 49);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Screws missing";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Dock = DockStyle.Top;
            checkBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(248, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Padding = new Padding(0, 0, 0, 8);
            checkBox2.Size = new Size(320, 49);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Evidence of tampering";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Top;
            checkBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(248, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(0, 0, 0, 8);
            checkBox1.Size = new Size(320, 49);
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
            panel3.Controls.Add(checkBox7);
            panel3.Controls.Add(checkBox6);
            panel3.Controls.Add(cableDamageCheckBox);
            panel3.Controls.Add(chargePortCheckBox);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 262);
            panel3.TabIndex = 5;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Dock = DockStyle.Top;
            checkBox7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(578, 147);
            checkBox7.Name = "checkBox7";
            checkBox7.Padding = new Padding(0, 0, 0, 8);
            checkBox7.Size = new Size(302, 49);
            checkBox7.TabIndex = 8;
            checkBox7.Text = "Communication Port";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Dock = DockStyle.Top;
            checkBox6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(578, 98);
            checkBox6.Name = "checkBox6";
            checkBox6.Padding = new Padding(0, 0, 0, 8);
            checkBox6.Size = new Size(302, 49);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "Gove Vent ";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // cableDamageCheckBox
            // 
            cableDamageCheckBox.AutoSize = true;
            cableDamageCheckBox.Dock = DockStyle.Top;
            cableDamageCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cableDamageCheckBox.Location = new Point(578, 49);
            cableDamageCheckBox.Name = "cableDamageCheckBox";
            cableDamageCheckBox.Padding = new Padding(0, 0, 0, 8);
            cableDamageCheckBox.Size = new Size(302, 49);
            cableDamageCheckBox.TabIndex = 6;
            cableDamageCheckBox.Text = "Cable Damage";
            cableDamageCheckBox.UseVisualStyleBackColor = true;
            // 
            // chargePortCheckBox
            // 
            chargePortCheckBox.AutoSize = true;
            chargePortCheckBox.Dock = DockStyle.Top;
            chargePortCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chargePortCheckBox.Location = new Point(578, 0);
            chargePortCheckBox.Name = "chargePortCheckBox";
            chargePortCheckBox.Padding = new Padding(0, 0, 0, 8);
            chargePortCheckBox.Size = new Size(302, 49);
            chargePortCheckBox.TabIndex = 5;
            chargePortCheckBox.Text = "Charge Port";
            chargePortCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(radioButton7);
            panel4.Controls.Add(radioButton6);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 342);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 98);
            panel4.TabIndex = 6;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Dock = DockStyle.Left;
            radioButton7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton7.Location = new Point(497, 0);
            radioButton7.Name = "radioButton7";
            radioButton7.Padding = new Padding(20, 0, 20, 0);
            radioButton7.Size = new Size(104, 98);
            radioButton7.TabIndex = 14;
            radioButton7.TabStop = true;
            radioButton7.Text = "No";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Dock = DockStyle.Left;
            radioButton6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton6.Location = new Point(391, 0);
            radioButton6.Name = "radioButton6";
            radioButton6.Padding = new Padding(20, 0, 20, 0);
            radioButton6.Size = new Size(106, 98);
            radioButton6.TabIndex = 13;
            radioButton6.TabStop = true;
            radioButton6.Text = "Yes";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(25);
            label4.Size = new Size(391, 87);
            label4.TabIndex = 9;
            label4.Text = "Battery Leads Protected: ";
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 440);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 17;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(530, 440);
            cancelButton.MaximumSize = new Size(175, 80);
            cancelButton.MinimumSize = new Size(175, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 80);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // BrmTicketCreationForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 556);
            Controls.Add(cancelButton);
            Controls.Add(continueButton);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            MinimumSize = new Size(0, 530);
            Name = "BrmTicketCreationForm2";
            Text = "serviceInspectionFirstForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private CheckBox chargePortCheckBox;
        private CheckBox cableDamageCheckBox;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Panel panel4;
        public Label label4;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Button continueButton;
        private Button cancelButton;
    }
}