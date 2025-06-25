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
            doesNotApplyShippingButton = new RadioButton();
            unsafeShippingButton = new RadioButton();
            safeShippingButton = new RadioButton();
            label3 = new Label();
            panel1 = new Panel();
            missingWiresCheckBox = new CheckBox();
            housingDentsCheckBox = new CheckBox();
            screwsMissingCheckBox = new CheckBox();
            evidenceOfTamperingCheckBox = new CheckBox();
            housingScrapesCheckBox = new CheckBox();
            label2 = new Label();
            panel3 = new Panel();
            commPortCheckBox = new CheckBox();
            goveVentCheckBox = new CheckBox();
            cableDamageCheckBox = new CheckBox();
            chargePortCheckBox = new CheckBox();
            panel4 = new Panel();
            battLeadProtectNo = new RadioButton();
            battLeadProtectYes = new RadioButton();
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
            panel2.Controls.Add(doesNotApplyShippingButton);
            panel2.Controls.Add(unsafeShippingButton);
            panel2.Controls.Add(safeShippingButton);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 5);
            panel2.Size = new Size(931, 78);
            panel2.TabIndex = 3;
            // 
            // doesNotApplyShippingButton
            // 
            doesNotApplyShippingButton.AutoSize = true;
            doesNotApplyShippingButton.Dock = DockStyle.Left;
            doesNotApplyShippingButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            doesNotApplyShippingButton.Location = new Point(562, 10);
            doesNotApplyShippingButton.Name = "doesNotApplyShippingButton";
            doesNotApplyShippingButton.Padding = new Padding(20, 0, 20, 0);
            doesNotApplyShippingButton.Size = new Size(241, 63);
            doesNotApplyShippingButton.TabIndex = 3;
            doesNotApplyShippingButton.TabStop = true;
            doesNotApplyShippingButton.Text = "Does not apply ";
            doesNotApplyShippingButton.UseVisualStyleBackColor = true;
            // 
            // unsafeShippingButton
            // 
            unsafeShippingButton.AutoSize = true;
            unsafeShippingButton.Dock = DockStyle.Left;
            unsafeShippingButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            unsafeShippingButton.Location = new Point(417, 10);
            unsafeShippingButton.Name = "unsafeShippingButton";
            unsafeShippingButton.Padding = new Padding(20, 0, 20, 0);
            unsafeShippingButton.Size = new Size(145, 63);
            unsafeShippingButton.TabIndex = 2;
            unsafeShippingButton.TabStop = true;
            unsafeShippingButton.Text = "Unsafe";
            unsafeShippingButton.UseVisualStyleBackColor = true;
            // 
            // safeShippingButton
            // 
            safeShippingButton.AutoSize = true;
            safeShippingButton.Dock = DockStyle.Left;
            safeShippingButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            safeShippingButton.Location = new Point(299, 10);
            safeShippingButton.Name = "safeShippingButton";
            safeShippingButton.Padding = new Padding(20, 0, 20, 0);
            safeShippingButton.Size = new Size(118, 63);
            safeShippingButton.TabIndex = 1;
            safeShippingButton.TabStop = true;
            safeShippingButton.Text = "Safe";
            safeShippingButton.UseVisualStyleBackColor = true;
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
            panel1.Controls.Add(missingWiresCheckBox);
            panel1.Controls.Add(housingDentsCheckBox);
            panel1.Controls.Add(screwsMissingCheckBox);
            panel1.Controls.Add(evidenceOfTamperingCheckBox);
            panel1.Controls.Add(housingScrapesCheckBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 10, 10, 5);
            panel1.Size = new Size(578, 262);
            panel1.TabIndex = 4;
            // 
            // missingWiresCheckBox
            // 
            missingWiresCheckBox.AutoSize = true;
            missingWiresCheckBox.Dock = DockStyle.Top;
            missingWiresCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            missingWiresCheckBox.Location = new Point(248, 206);
            missingWiresCheckBox.Name = "missingWiresCheckBox";
            missingWiresCheckBox.Padding = new Padding(0, 0, 0, 8);
            missingWiresCheckBox.Size = new Size(320, 49);
            missingWiresCheckBox.TabIndex = 5;
            missingWiresCheckBox.Text = "Missing Wires";
            missingWiresCheckBox.UseVisualStyleBackColor = true;
            // 
            // housingDentsCheckBox
            // 
            housingDentsCheckBox.AutoSize = true;
            housingDentsCheckBox.Dock = DockStyle.Top;
            housingDentsCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            housingDentsCheckBox.Location = new Point(248, 157);
            housingDentsCheckBox.Name = "housingDentsCheckBox";
            housingDentsCheckBox.Padding = new Padding(0, 0, 0, 8);
            housingDentsCheckBox.Size = new Size(320, 49);
            housingDentsCheckBox.TabIndex = 4;
            housingDentsCheckBox.Text = "Housing dents / holes";
            housingDentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // screwsMissingCheckBox
            // 
            screwsMissingCheckBox.AutoSize = true;
            screwsMissingCheckBox.Dock = DockStyle.Top;
            screwsMissingCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            screwsMissingCheckBox.Location = new Point(248, 108);
            screwsMissingCheckBox.Name = "screwsMissingCheckBox";
            screwsMissingCheckBox.Padding = new Padding(0, 0, 0, 8);
            screwsMissingCheckBox.Size = new Size(320, 49);
            screwsMissingCheckBox.TabIndex = 3;
            screwsMissingCheckBox.Text = "Screws missing";
            screwsMissingCheckBox.UseVisualStyleBackColor = true;
            // 
            // evidenceOfTamperingCheckBox
            // 
            evidenceOfTamperingCheckBox.AutoSize = true;
            evidenceOfTamperingCheckBox.Dock = DockStyle.Top;
            evidenceOfTamperingCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            evidenceOfTamperingCheckBox.Location = new Point(248, 59);
            evidenceOfTamperingCheckBox.Name = "evidenceOfTamperingCheckBox";
            evidenceOfTamperingCheckBox.Padding = new Padding(0, 0, 0, 8);
            evidenceOfTamperingCheckBox.Size = new Size(320, 49);
            evidenceOfTamperingCheckBox.TabIndex = 2;
            evidenceOfTamperingCheckBox.Text = "Evidence of tampering";
            evidenceOfTamperingCheckBox.UseVisualStyleBackColor = true;
            // 
            // housingScrapesCheckBox
            // 
            housingScrapesCheckBox.AutoSize = true;
            housingScrapesCheckBox.Dock = DockStyle.Top;
            housingScrapesCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            housingScrapesCheckBox.Location = new Point(248, 10);
            housingScrapesCheckBox.Name = "housingScrapesCheckBox";
            housingScrapesCheckBox.Padding = new Padding(0, 0, 0, 8);
            housingScrapesCheckBox.Size = new Size(320, 49);
            housingScrapesCheckBox.TabIndex = 1;
            housingScrapesCheckBox.Text = "Housing Scrapes";
            housingScrapesCheckBox.UseVisualStyleBackColor = true;
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
            panel3.Controls.Add(commPortCheckBox);
            panel3.Controls.Add(goveVentCheckBox);
            panel3.Controls.Add(cableDamageCheckBox);
            panel3.Controls.Add(chargePortCheckBox);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(931, 262);
            panel3.TabIndex = 5;
            // 
            // commPortCheckBox
            // 
            commPortCheckBox.AutoSize = true;
            commPortCheckBox.Dock = DockStyle.Top;
            commPortCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            commPortCheckBox.Location = new Point(578, 147);
            commPortCheckBox.Name = "commPortCheckBox";
            commPortCheckBox.Padding = new Padding(0, 0, 0, 8);
            commPortCheckBox.Size = new Size(353, 49);
            commPortCheckBox.TabIndex = 8;
            commPortCheckBox.Text = "Communication Port";
            commPortCheckBox.UseVisualStyleBackColor = true;
            // 
            // goveVentCheckBox
            // 
            goveVentCheckBox.AutoSize = true;
            goveVentCheckBox.Dock = DockStyle.Top;
            goveVentCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            goveVentCheckBox.Location = new Point(578, 98);
            goveVentCheckBox.Name = "goveVentCheckBox";
            goveVentCheckBox.Padding = new Padding(0, 0, 0, 8);
            goveVentCheckBox.Size = new Size(353, 49);
            goveVentCheckBox.TabIndex = 7;
            goveVentCheckBox.Text = "Gove Vent ";
            goveVentCheckBox.UseVisualStyleBackColor = true;
            // 
            // cableDamageCheckBox
            // 
            cableDamageCheckBox.AutoSize = true;
            cableDamageCheckBox.Dock = DockStyle.Top;
            cableDamageCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cableDamageCheckBox.Location = new Point(578, 49);
            cableDamageCheckBox.Name = "cableDamageCheckBox";
            cableDamageCheckBox.Padding = new Padding(0, 0, 0, 8);
            cableDamageCheckBox.Size = new Size(353, 49);
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
            chargePortCheckBox.Size = new Size(353, 49);
            chargePortCheckBox.TabIndex = 5;
            chargePortCheckBox.Text = "Charge Port";
            chargePortCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(battLeadProtectNo);
            panel4.Controls.Add(battLeadProtectYes);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 340);
            panel4.Name = "panel4";
            panel4.Size = new Size(931, 71);
            panel4.TabIndex = 6;
            // 
            // battLeadProtectNo
            // 
            battLeadProtectNo.AutoSize = true;
            battLeadProtectNo.Dock = DockStyle.Left;
            battLeadProtectNo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            battLeadProtectNo.Location = new Point(497, 0);
            battLeadProtectNo.Name = "battLeadProtectNo";
            battLeadProtectNo.Padding = new Padding(20, 0, 20, 0);
            battLeadProtectNo.Size = new Size(104, 71);
            battLeadProtectNo.TabIndex = 14;
            battLeadProtectNo.TabStop = true;
            battLeadProtectNo.Text = "No";
            battLeadProtectNo.UseVisualStyleBackColor = true;
            // 
            // battLeadProtectYes
            // 
            battLeadProtectYes.AutoSize = true;
            battLeadProtectYes.Dock = DockStyle.Left;
            battLeadProtectYes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            battLeadProtectYes.Location = new Point(391, 0);
            battLeadProtectYes.Name = "battLeadProtectYes";
            battLeadProtectYes.Padding = new Padding(20, 0, 20, 0);
            battLeadProtectYes.Size = new Size(106, 71);
            battLeadProtectYes.TabIndex = 13;
            battLeadProtectYes.TabStop = true;
            battLeadProtectYes.Text = "Yes";
            battLeadProtectYes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(25, 15, 25, 25);
            label4.Size = new Size(391, 77);
            label4.TabIndex = 9;
            label4.Text = "Battery Leads Protected: ";
            // 
            // continueButton
            // 
            continueButton.AutoSize = true;
            continueButton.Dock = DockStyle.Right;
            continueButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            continueButton.Location = new Point(756, 411);
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
            cancelButton.Location = new Point(581, 411);
            cancelButton.MaximumSize = new Size(175, 80);
            cancelButton.MinimumSize = new Size(175, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 80);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Back";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // BrmTicketCreationForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 511);
            Controls.Add(cancelButton);
            Controls.Add(continueButton);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            MinimumSize = new Size(947, 550);
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
        private RadioButton doesNotApplyShippingButton;
        private RadioButton unsafeShippingButton;
        private RadioButton safeShippingButton;
        private Label label3;
        private Panel panel1;
        private CheckBox missingWiresCheckBox;
        private CheckBox housingDentsCheckBox;
        private CheckBox screwsMissingCheckBox;
        private CheckBox evidenceOfTamperingCheckBox;
        private CheckBox housingScrapesCheckBox;
        private Label label2;
        private Panel panel3;
        private CheckBox chargePortCheckBox;
        private CheckBox cableDamageCheckBox;
        private CheckBox goveVentCheckBox;
        private CheckBox commPortCheckBox;
        private Panel panel4;
        public Label label4;
        private RadioButton battLeadProtectYes;
        private RadioButton battLeadProtectNo;
        private Button continueButton;
        private Button cancelButton;
    }
}