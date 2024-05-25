using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopSupport.SmallForms
{
    public partial class WithExpireDate : Form
    {
        public bool WithED = false;
        public WithExpireDate()
        {
            InitializeComponent();
        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            WithED = true;

            Close();
        }

        private void skyButton2_Click(object sender, EventArgs e)
        {
            WithED = false;

            Close();
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
