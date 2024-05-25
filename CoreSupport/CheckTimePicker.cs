using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopSupport
{
    public partial class CheckTimePicker : UserControl
    {
        public CheckTimePicker()
        {
            InitializeComponent();
        }

        private void IsEmpty_CheckedChanged(object sender, EventArgs e)
        {
            Picker.Enabled = CanUse.Checked;
        }
    }
}
