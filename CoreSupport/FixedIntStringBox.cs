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
    public partial class FixedIntStringBox : TextBox
    {
        public int IncreaseHeight { get; set; } = 10;
        public override bool Multiline 
        { 
            get => base.Multiline; 
            set
            {
                base.Multiline = value;

                if (base.Multiline)
                {
                    Height = Baseheight + IncreaseHeight;
                }
                else
                {
                    Height = Baseheight - IncreaseHeight;
                }
            }
        }
        int Baseheight = 1;
        int BaseWidth = 1;
        public bool IntegerOnly { get; set; }
        public int Value
        {
            get => Text.IntOrDefault();
            set
            {
                if (value > 0)
                    Text = value.ToString();
            }
        }

        public FixedIntStringBox()
        {
            InitializeComponent();

            Baseheight = Height;
            BaseWidth = Width;
        }

        private void FixedIntBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }

            if (IntegerOnly)
            {
                try
                {
                    int.Parse(e.KeyChar.ToString());
                }
                catch { e.Handled = true; }
            }
        }
    }
}
