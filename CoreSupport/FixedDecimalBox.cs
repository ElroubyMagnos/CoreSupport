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
    public partial class FixedDecimalBox : TextBox
    {
        public decimal Value
        {
            get => Text.DecimalOrDefault();
            set
            {
                var Split = value.ToString().Split('.');
                if (Split.Length > 1 && Split[1].Length > 2)
                {
                    Text = Split[0] + "." + Split[1][0] + Split[1][1];
                }
                else Text = value.ToString();
            }
        }
        public FixedDecimalBox()
        {
            InitializeComponent();
        }

        private void FixedDecimalBox_LostFocus(object sender, EventArgs e)
        {
            if (Text != "" && Text.Last() == '.')
            {
                Text += "";
            }
        }

        private void FixedDecimalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }

            if (Text.Length == 0 && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }

            if (Text.Contains(".") && e.KeyChar == '.')
            { 
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')
            {
                return;
            }

            try
            {
                decimal.Parse(e.KeyChar.ToString());
            }
            catch { e.Handled = true; }
        }
    }
}
