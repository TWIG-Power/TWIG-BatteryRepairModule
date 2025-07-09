namespace BatteryRepairModule.Forms.Shipping
{
    partial class shippingForm
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
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            stateOfHealthFilterDropDown = new ComboBox();
            label3 = new Label();
            moduleOemFilterDropDown = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            markModuleAsShipped = new Button();
            panel6 = new Panel();
            panel10 = new Panel();
            markModuleAsInvoiced = new Button();
            panel5 = new Panel();
            invoicedListBox = new ListBox();
            panel4 = new Panel();
            readyInventoryListBox = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 54);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(488, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 10, 10);
            label2.Size = new Size(174, 51);
            label2.TabIndex = 8;
            label2.Text = "Invoiced: ";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(285, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(203, 54);
            panel7.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 10, 10);
            label1.Size = new Size(285, 51);
            label1.TabIndex = 0;
            label1.Text = "Ready Inventory: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(stateOfHealthFilterDropDown);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(moduleOemFilterDropDown);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 54);
            panel2.TabIndex = 5;
            // 
            // stateOfHealthFilterDropDown
            // 
            stateOfHealthFilterDropDown.Dock = DockStyle.Left;
            stateOfHealthFilterDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            stateOfHealthFilterDropDown.FormattingEnabled = true;
            stateOfHealthFilterDropDown.Location = new Point(658, 0);
            stateOfHealthFilterDropDown.MaximumSize = new Size(500, 0);
            stateOfHealthFilterDropDown.Name = "stateOfHealthFilterDropDown";
            stateOfHealthFilterDropDown.Size = new Size(255, 45);
            stateOfHealthFilterDropDown.TabIndex = 9;
            stateOfHealthFilterDropDown.SelectedIndexChanged += stateOfHealthFilterDropDown_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(449, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 10, 10);
            label3.Size = new Size(209, 42);
            label3.TabIndex = 8;
            label3.Text = "State Of Health: ";
            // 
            // moduleOemFilterDropDown
            // 
            moduleOemFilterDropDown.Dock = DockStyle.Left;
            moduleOemFilterDropDown.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            moduleOemFilterDropDown.FormattingEnabled = true;
            moduleOemFilterDropDown.Location = new Point(188, 0);
            moduleOemFilterDropDown.MaximumSize = new Size(500, 0);
            moduleOemFilterDropDown.Name = "moduleOemFilterDropDown";
            moduleOemFilterDropDown.Size = new Size(261, 45);
            moduleOemFilterDropDown.TabIndex = 7;
            moduleOemFilterDropDown.SelectedIndexChanged += moduleOemFilterDropDown_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 0, 10, 10);
            label4.Size = new Size(188, 42);
            label4.TabIndex = 0;
            label4.Text = "Module OEM: ";
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(931, 63);
            panel3.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel8.Controls.Add(markModuleAsShipped);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(473, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(2);
            panel8.Size = new Size(450, 63);
            panel8.TabIndex = 18;
            // 
            // markModuleAsShipped
            // 
            markModuleAsShipped.AutoSize = true;
            markModuleAsShipped.Dock = DockStyle.Fill;
            markModuleAsShipped.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            markModuleAsShipped.Location = new Point(2, 2);
            markModuleAsShipped.Name = "markModuleAsShipped";
            markModuleAsShipped.Padding = new Padding(3);
            markModuleAsShipped.Size = new Size(446, 59);
            markModuleAsShipped.TabIndex = 18;
            markModuleAsShipped.Text = "Mark Module As Shipped";
            markModuleAsShipped.UseVisualStyleBackColor = true;
            markModuleAsShipped.Click += markModuleAsShipped_Click;
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(450, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(2);
            panel6.Size = new Size(23, 63);
            panel6.TabIndex = 17;
            // 
            // panel10
            // 
            panel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel10.Controls.Add(markModuleAsInvoiced);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(3);
            panel10.Size = new Size(450, 63);
            panel10.TabIndex = 15;
            // 
            // markModuleAsInvoiced
            // 
            markModuleAsInvoiced.AutoSize = true;
            markModuleAsInvoiced.Dock = DockStyle.Fill;
            markModuleAsInvoiced.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            markModuleAsInvoiced.Location = new Point(3, 3);
            markModuleAsInvoiced.Name = "markModuleAsInvoiced";
            markModuleAsInvoiced.Size = new Size(444, 57);
            markModuleAsInvoiced.TabIndex = 17;
            markModuleAsInvoiced.Text = "Mark Module As Invoiced";
            markModuleAsInvoiced.UseVisualStyleBackColor = true;
            markModuleAsInvoiced.Click += markModuleAsInvoiced_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(invoicedListBox);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(readyInventoryListBox);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(931, 336);
            panel5.TabIndex = 26;
            // 
            // invoicedListBox
            // 
            invoicedListBox.Dock = DockStyle.Left;
            invoicedListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            invoicedListBox.FormattingEnabled = true;
            invoicedListBox.ItemHeight = 30;
            invoicedListBox.Location = new Point(473, 0);
            invoicedListBox.Name = "invoicedListBox";
            invoicedListBox.Size = new Size(452, 336);
            invoicedListBox.TabIndex = 4;
            invoicedListBox.SelectedIndexChanged += invoicedListBox_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(450, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(23, 336);
            panel4.TabIndex = 1;
            // 
            // readyInventoryListBox
            // 
            readyInventoryListBox.Dock = DockStyle.Left;
            readyInventoryListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            readyInventoryListBox.FormattingEnabled = true;
            readyInventoryListBox.ItemHeight = 30;
            readyInventoryListBox.Location = new Point(0, 0);
            readyInventoryListBox.Name = "readyInventoryListBox";
            readyInventoryListBox.Size = new Size(450, 336);
            readyInventoryListBox.TabIndex = 0;
            readyInventoryListBox.SelectedIndexChanged += readyInventoryListBox_SelectedIndexChanged;
            // 
            // shippingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 511);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "shippingForm";
            Text = "shippingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel7;
        private Panel panel2;
        private Label label4;
        private ComboBox stateOfHealthFilterDropDown;
        private Label label3;
        private ComboBox moduleOemFilterDropDown;
        private Panel panel3;
        private Panel panel8;
        private Button markModuleAsShipped;
        private Panel panel6;
        private Panel panel10;
        private Button markModuleAsInvoiced;
        private Panel panel5;
        private ListBox invoicedListBox;
        private Panel panel4;
        private ListBox readyInventoryListBox;
        private Button addRepairNotesButton;
        private Panel panel11;
        private Button viewRepairNotesButton;
    }
}