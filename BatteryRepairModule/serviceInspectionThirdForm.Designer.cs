using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class serviceInspectionThirdForm
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
            panel3 = new Panel();
            recycleRadioButton = new RadioButton();
            repairActionRadioButton = new RadioButton();
            label4 = new Label();
            panel1 = new Panel();
            communicationPortCheckBox = new CheckBox();
            goveVentCheckBox = new CheckBox();
            cableDamageCheckBox = new CheckBox();
            chargePortCheckBox = new CheckBox();
            label2 = new Label();
            panel2 = new Panel();
            notesTextBox = new RichTextBox();
            label1 = new Label();
            continueButton = new Button();
            backButton = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(recycleRadioButton);
            panel3.Controls.Add(repairActionRadioButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 214);
            panel3.TabIndex = 6;
            // 
            // recycleRadioButton
            // 
            recycleRadioButton.AutoSize = true;
            recycleRadioButton.Dock = DockStyle.Top;
            recycleRadioButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            recycleRadioButton.Location = new Point(580, 92);
            recycleRadioButton.Name = "recycleRadioButton";
            recycleRadioButton.Padding = new Padding(20, 0, 20, 0);
            recycleRadioButton.Size = new Size(300, 41);
            recycleRadioButton.TabIndex = 10;
            recycleRadioButton.TabStop = true;
            recycleRadioButton.Text = "Recycle";
            recycleRadioButton.UseVisualStyleBackColor = true;
            // 
            // repairActionRadioButton
            // 
            repairActionRadioButton.AutoSize = true;
            repairActionRadioButton.Dock = DockStyle.Top;
            repairActionRadioButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            repairActionRadioButton.Location = new Point(580, 51);
            repairActionRadioButton.Name = "repairActionRadioButton";
            repairActionRadioButton.Padding = new Padding(20, 0, 20, 0);
            repairActionRadioButton.Size = new Size(300, 41);
            repairActionRadioButton.TabIndex = 9;
            repairActionRadioButton.TabStop = true;
            repairActionRadioButton.Text = "Repair";
            repairActionRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label4.Location = new Point(580, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 25, 10);
            label4.Size = new Size(238, 51);
            label4.TabIndex = 5;
            label4.Text = "Next Action: ";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(communicationPortCheckBox);
            panel1.Controls.Add(goveVentCheckBox);
            panel1.Controls.Add(cableDamageCheckBox);
            panel1.Controls.Add(chargePortCheckBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 10, 10, 5);
            panel1.Size = new Size(580, 214);
            panel1.TabIndex = 4;
            // 
            // communicationPortCheckBox
            // 
            communicationPortCheckBox.AutoSize = true;
            communicationPortCheckBox.Dock = DockStyle.Top;
            communicationPortCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            communicationPortCheckBox.Location = new Point(259, 157);
            communicationPortCheckBox.Name = "communicationPortCheckBox";
            communicationPortCheckBox.Padding = new Padding(0, 0, 0, 8);
            communicationPortCheckBox.Size = new Size(311, 49);
            communicationPortCheckBox.TabIndex = 4;
            communicationPortCheckBox.Text = "Communication Port";
            communicationPortCheckBox.UseVisualStyleBackColor = true;
            communicationPortCheckBox.CheckedChanged += communicationPortCheckBox_CheckedChanged;
            // 
            // goveVentCheckBox
            // 
            goveVentCheckBox.AutoSize = true;
            goveVentCheckBox.Dock = DockStyle.Top;
            goveVentCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            goveVentCheckBox.Location = new Point(259, 108);
            goveVentCheckBox.Name = "goveVentCheckBox";
            goveVentCheckBox.Padding = new Padding(0, 0, 0, 8);
            goveVentCheckBox.Size = new Size(311, 49);
            goveVentCheckBox.TabIndex = 3;
            goveVentCheckBox.Text = "Gove Vent ";
            goveVentCheckBox.UseVisualStyleBackColor = true;
            goveVentCheckBox.CheckedChanged += goveVentCheckBox_CheckedChanged;
            // 
            // cableDamageCheckBox
            // 
            cableDamageCheckBox.AutoSize = true;
            cableDamageCheckBox.Dock = DockStyle.Top;
            cableDamageCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cableDamageCheckBox.Location = new Point(259, 59);
            cableDamageCheckBox.Name = "cableDamageCheckBox";
            cableDamageCheckBox.Padding = new Padding(0, 0, 0, 8);
            cableDamageCheckBox.Size = new Size(311, 49);
            cableDamageCheckBox.TabIndex = 2;
            cableDamageCheckBox.Text = "Cable Damage";
            cableDamageCheckBox.UseVisualStyleBackColor = true;
            cableDamageCheckBox.CheckedChanged += cableDamageCheckBox_CheckedChanged;
            // 
            // chargePortCheckBox
            // 
            chargePortCheckBox.AutoSize = true;
            chargePortCheckBox.Dock = DockStyle.Top;
            chargePortCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chargePortCheckBox.Location = new Point(259, 10);
            chargePortCheckBox.Name = "chargePortCheckBox";
            chargePortCheckBox.Padding = new Padding(0, 0, 0, 8);
            chargePortCheckBox.Size = new Size(311, 49);
            chargePortCheckBox.TabIndex = 1;
            chargePortCheckBox.Text = "Charge Port";
            chargePortCheckBox.UseVisualStyleBackColor = true;
            chargePortCheckBox.CheckedChanged += chargePortCheckBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 25, 10);
            label2.Size = new Size(249, 51);
            label2.TabIndex = 0;
            label2.Text = "Check Battery";
            // 
            // panel2
            // 
            panel2.Controls.Add(notesTextBox);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 262);
            panel2.TabIndex = 7;
            // 
            // notesTextBox
            // 
            notesTextBox.Dock = DockStyle.Fill;
            notesTextBox.Location = new Point(0, 51);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(880, 211);
            notesTextBox.TabIndex = 7;
            notesTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 25, 10);
            label1.Size = new Size(144, 51);
            label1.TabIndex = 6;
            label1.Text = "Notes:";
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 476);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 9;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Dock = DockStyle.Right;
            backButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(530, 476);
            backButton.MaximumSize = new Size(175, 80);
            backButton.MinimumSize = new Size(175, 80);
            backButton.Name = "backButton";
            backButton.Size = new Size(175, 80);
            backButton.TabIndex = 10;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // serviceInspectionThirdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 556);
            Controls.Add(backButton);
            Controls.Add(continueButton);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "serviceInspectionThirdForm";
            Text = "serviceInspectionThirdForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private RadioButton recycleRadioButton;
        private RadioButton repairActionRadioButton;
        public Label label4;
        private Panel panel1;
        private CheckBox communicationPortCheckBox;
        private CheckBox goveVentCheckBox;
        private CheckBox cableDamageCheckBox;
        private CheckBox chargePortCheckBox;
        private Label label2;
        private Panel panel2;
        public Label label1;
        private Button continueButton;
        private Button backButton;
        private RichTextBox notesTextBox;
    }
}