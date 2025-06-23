using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteryRepairModule.Forms.BRM;

namespace BatteryRepairModule.Forms.Service_Inspection_Forms
{
    public partial class serviceInspectionForm2 : Form
    {
        private BrmMainMenuForm parentForm;
        public serviceInspectionForm2(BrmMainMenuForm parentRef)
        {
            InitializeComponent();
            this.parentForm = parentRef; 
        }
    }
}
