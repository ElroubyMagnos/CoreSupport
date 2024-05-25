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
    public partial class FixedIntComboBox : ComboBox
    {
        public bool ReadOnly { get; set; }
        public int Value
        {
            get => Text.IntOrDefault();
            set
            {
                Text = value.ToString();
            }
        }

        public FixedIntComboBox()
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

            if (e.KeyChar == '\b')
            {
                return;
            }

            try
            {
                int.Parse(e.KeyChar.ToString());
            }
            catch { e.Handled = true; }
        }
    }
}
