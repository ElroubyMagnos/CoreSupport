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
    public partial class FixedIntBox : TextBox
    {
        public int Value
        {
            get => Text.IntOrDefault();
            set 
            {
                Text = value.ToString();
            } 
        }

        public FixedIntBox()
        {
            InitializeComponent();
        }

        private void FixedIntBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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
