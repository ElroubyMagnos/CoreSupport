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
    public partial class IntegerBox : TextBox
    {
        public int Value
        {
            get
            {
                int Integer;
                int.TryParse(Text, out Integer);

                Text = Integer.ToString();

                return Integer;
            }
            set
            {
                Text = value.ToString();
            }
        }

        public IntegerBox()
        {
            InitializeComponent();

            IntBox_TextChanged(null, null);
        }

        private void IntBox_TextChanged(object sender, EventArgs e)
        {
            int Integer;
            int.TryParse(Text, out Integer);

            Text = Integer.ToString();

            if (Text == "")
            {
                SelectionStart = 0;
                SelectionLength = 1;
            }
        }

        private void IntBox_GotFocus(object sender, EventArgs e)
        {
            if (Text == "")
            {
                SelectionStart = 0;
                SelectionLength = 1;
            }
        }
    }
}
