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
    public partial class FixedStringComboBox : ComboBox
    {
        public bool ReadOnly { get; set; }

        public FixedStringComboBox()
        {
            InitializeComponent();
        }

        private void FixedIntBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ReadOnly)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
