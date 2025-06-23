using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BatteryRepairModule.Forms.BRM
{
    partial class serviceInspectionSecondForm
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
            cleanHousingCheckBox = new CheckBox();
            label3 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            thirtyMinuteDryCheckBox = new CheckBox();
            label1 = new Label();
            panel4 = new Panel();
            diagnosticToolCheckBox = new CheckBox();
            label2 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
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
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel12.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(cleanHousingCheckBox);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 5);
            panel2.Size = new Size(473, 65);
            panel2.TabIndex = 4;
            // 
            // cleanHousingCheckBox
            // 
            cleanHousingCheckBox.AutoSize = true;
            cleanHousingCheckBox.Dock = DockStyle.Fill;
            cleanHousingCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cleanHousingCheckBox.Location = new Point(275, 10);
            cleanHousingCheckBox.Name = "cleanHousingCheckBox";
            cleanHousingCheckBox.Size = new Size(188, 50);
            cleanHousingCheckBox.TabIndex = 1;
            cleanHousingCheckBox.Text = "Done";
            cleanHousingCheckBox.UseVisualStyleBackColor = true;
            cleanHousingCheckBox.CheckedChanged += cleanHousingCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 25, 10);
            label3.Size = new Size(265, 51);
            label3.TabIndex = 0;
            label3.Text = "Clean Housing:";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 65);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(thirtyMinuteDryCheckBox);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(473, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 10, 10, 5);
            panel3.Size = new Size(516, 65);
            panel3.TabIndex = 5;
            // 
            // thirtyMinuteDryCheckBox
            // 
            thirtyMinuteDryCheckBox.AutoSize = true;
            thirtyMinuteDryCheckBox.Dock = DockStyle.Fill;
            thirtyMinuteDryCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            thirtyMinuteDryCheckBox.Location = new Point(282, 10);
            thirtyMinuteDryCheckBox.Name = "thirtyMinuteDryCheckBox";
            thirtyMinuteDryCheckBox.Size = new Size(224, 50);
            thirtyMinuteDryCheckBox.TabIndex = 1;
            thirtyMinuteDryCheckBox.Text = "Done";
            thirtyMinuteDryCheckBox.UseVisualStyleBackColor = true;
            thirtyMinuteDryCheckBox.CheckedChanged += thirtyMinuteDryCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 25, 10);
            label1.Size = new Size(272, 51);
            label1.TabIndex = 0;
            label1.Text = "30 Minute Dry: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(diagnosticToolCheckBox);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 50);
            panel4.TabIndex = 6;
            // 
            // diagnosticToolCheckBox
            // 
            diagnosticToolCheckBox.AutoSize = true;
            diagnosticToolCheckBox.Dock = DockStyle.Fill;
            diagnosticToolCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            diagnosticToolCheckBox.Location = new Point(479, 0);
            diagnosticToolCheckBox.Name = "diagnosticToolCheckBox";
            diagnosticToolCheckBox.Size = new Size(401, 50);
            diagnosticToolCheckBox.TabIndex = 2;
            diagnosticToolCheckBox.Text = "Done";
            diagnosticToolCheckBox.UseVisualStyleBackColor = true;
            diagnosticToolCheckBox.CheckedChanged += diagnosticToolCheckBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 25, 10);
            label2.Size = new Size(479, 51);
            label2.TabIndex = 1;
            label2.Text = "Plugged Into Diagnostic Tool: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(880, 50);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(440, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 0, 25, 10);
            label5.Size = new Size(254, 51);
            label5.TabIndex = 6;
            label5.Text = "Added Errors: ";
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(232, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(208, 50);
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
            label4.Size = new Size(232, 51);
            label4.TabIndex = 1;
            label4.Text = "Error Codes: ";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(880, 224);
            panel6.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Controls.Add(addedErrorsListBox);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(errorsListBox);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(880, 222);
            panel7.TabIndex = 10;
            // 
            // addedErrorsListBox
            // 
            addedErrorsListBox.Dock = DockStyle.Left;
            addedErrorsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addedErrorsListBox.FormattingEnabled = true;
            addedErrorsListBox.ItemHeight = 32;
            addedErrorsListBox.Location = new Point(458, 0);
            addedErrorsListBox.Name = "addedErrorsListBox";
            addedErrorsListBox.Size = new Size(422, 222);
            addedErrorsListBox.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(421, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(37, 222);
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
            errorsListBox.Size = new Size(421, 222);
            errorsListBox.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel14);
            panel12.Controls.Add(panel13);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 389);
            panel12.Name = "panel12";
            panel12.Size = new Size(880, 73);
            panel12.TabIndex = 12;
            // 
            // panel14
            // 
            panel14.Controls.Add(button2);
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(440, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(440, 73);
            panel14.TabIndex = 1;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(440, 73);
            button2.TabIndex = 19;
            button2.Text = "Remove Error Code";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(button1);
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(440, 73);
            panel13.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(440, 73);
            button1.TabIndex = 18;
            button1.Text = "Add Error Code";
            button1.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(530, 462);
            cancelButton.MaximumSize = new Size(175, 80);
            cancelButton.MinimumSize = new Size(175, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 80);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += backButton_Click;
            // 
            // continueButton
            // 
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(705, 462);
            continueButton.MaximumSize = new Size(175, 80);
            continueButton.MinimumSize = new Size(175, 80);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(175, 80);
            continueButton.TabIndex = 13;
            continueButton.Text = "Continue ";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // serviceInspectionSecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 556);
            Controls.Add(cancelButton);
            Controls.Add(continueButton);
            Controls.Add(panel12);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MinimumSize = new Size(0, 540);
            Name = "serviceInspectionSecondForm";
            Text = "serviceInspectionSecondForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CheckBox cleanHousingCheckBox;
        private Label label3;
        private Panel panel1;
        private Panel panel3;
        private CheckBox thirtyMinuteDryCheckBox;
        private Label label1;
        private Panel panel4;
        private CheckBox diagnosticToolCheckBox;
        private Label label2;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Panel panel7;
        private ListBox addedErrorsListBox;
        private Panel panel9;
        private ListBox errorsListBox;
        private Label label5;
        private Panel panel10;
        private Panel panel12;
        private Panel panel14;
        private Button button2;
        private Panel panel13;
        private Button button1;
        private Button cancelButton;
        private Button continueButton;
    }
}