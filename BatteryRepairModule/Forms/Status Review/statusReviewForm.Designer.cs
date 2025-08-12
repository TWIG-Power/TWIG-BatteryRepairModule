namespace BatteryRepairModule.Forms.Status_Review
{
    partial class statusReviewForm
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
            moduleOemFilterDropDown = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            partNumberModelFilter = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            queryListBox = new ListBox();
            panel4 = new Panel();
            panel8 = new Panel();
            viewDetailedReport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(moduleOemFilterDropDown);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(7, 8, 7, 8);
            panel1.Size = new Size(1330, 90);
            panel1.TabIndex = 5;
            // 
            // moduleOemFilterDropDown
            // 
            moduleOemFilterDropDown.Dock = DockStyle.Left;
            moduleOemFilterDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            moduleOemFilterDropDown.FormattingEnabled = true;
            moduleOemFilterDropDown.Location = new Point(777, 8);
            moduleOemFilterDropDown.Margin = new Padding(4, 5, 4, 5);
            moduleOemFilterDropDown.MaximumSize = new Size(713, 0);
            moduleOemFilterDropDown.Name = "moduleOemFilterDropDown";
            moduleOemFilterDropDown.Size = new Size(488, 62);
            moduleOemFilterDropDown.TabIndex = 8;
            moduleOemFilterDropDown.SelectedIndexChanged += moduleOemFilterDropDown_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(14, 0, 14, 17);
            label1.Size = new Size(770, 77);
            label1.TabIndex = 0;
            label1.Text = "Original Equipment Manufacturer:";
            // 
            // panel2
            // 
            panel2.Controls.Add(partNumberModelFilter);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 90);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(7, 8, 7, 8);
            panel2.Size = new Size(1330, 90);
            panel2.TabIndex = 6;
            // 
            // partNumberModelFilter
            // 
            partNumberModelFilter.Dock = DockStyle.Left;
            partNumberModelFilter.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            partNumberModelFilter.FormattingEnabled = true;
            partNumberModelFilter.Location = new Point(776, 8);
            partNumberModelFilter.Margin = new Padding(4, 5, 4, 5);
            partNumberModelFilter.MaximumSize = new Size(713, 0);
            partNumberModelFilter.Name = "partNumberModelFilter";
            partNumberModelFilter.Size = new Size(488, 62);
            partNumberModelFilter.TabIndex = 10;
            partNumberModelFilter.SelectedIndexChanged += partNumberModelFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(14, 0, 129, 17);
            label2.Size = new Size(769, 77);
            label2.TabIndex = 0;
            label2.Text = "Ticket Status:                           ";
            // 
            // panel3
            // 
            panel3.Controls.Add(queryListBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 180);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.MinimumSize = new Size(1330, 533);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(7, 8, 7, 8);
            panel3.Size = new Size(1330, 533);
            panel3.TabIndex = 7;
            // 
            // queryListBox
            // 
            queryListBox.Dock = DockStyle.Fill;
            queryListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            queryListBox.FormattingEnabled = true;
            queryListBox.ItemHeight = 45;
            queryListBox.Location = new Point(7, 8);
            queryListBox.Margin = new Padding(4, 5, 4, 5);
            queryListBox.MaximumSize = new Size(1313, 4);
            queryListBox.MinimumSize = new Size(1313, 514);
            queryListBox.Name = "queryListBox";
            queryListBox.Size = new Size(1313, 514);
            queryListBox.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 713);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1330, 135);
            panel4.TabIndex = 28;
            // 
            // panel8
            // 
            panel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel8.Controls.Add(viewDetailedReport);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(3, 3, 3, 3);
            panel8.Size = new Size(1321, 135);
            panel8.TabIndex = 18;
            // 
            // viewDetailedReport
            // 
            viewDetailedReport.AutoSize = true;
            viewDetailedReport.Dock = DockStyle.Fill;
            viewDetailedReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewDetailedReport.Location = new Point(3, 3);
            viewDetailedReport.Margin = new Padding(4, 5, 4, 5);
            viewDetailedReport.Name = "viewDetailedReport";
            viewDetailedReport.Padding = new Padding(4, 5, 4, 5);
            viewDetailedReport.Size = new Size(1315, 129);
            viewDetailedReport.TabIndex = 18;
            viewDetailedReport.Text = "View Detailed Report ";
            viewDetailedReport.UseVisualStyleBackColor = true;
            viewDetailedReport.Click += viewDetailedReport_Click;
            // 
            // statusReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 852);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1343, 879);
            Name = "statusReviewForm";
            Text = "statusReviewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ComboBox moduleOemFilterDropDown;
        private ComboBox partNumberModelFilter;
        private Panel panel3;
        private ListBox queryListBox;
        private Panel panel4;
        private Panel panel8;
        private Button viewDetailedReport;
    }
}