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
    public partial class PasswordBox : UserControl
    {
        public PasswordBox()
        {
            InitializeComponent();
        }

        private void PassShow_Click(object sender, EventArgs e)
        {
            PasswordContainer.UseSystemPasswordChar = !PasswordContainer.UseSystemPasswordChar;
        }
    }
}
