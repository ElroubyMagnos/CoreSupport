using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisionSystem.Particles
{
    public partial class InputBox : Form
    {
        public bool Accepted = false;
        string pass;
        public InputBox(string Message, string Password)
        {
            InitializeComponent();

            Msg.Text = Message;
            pass = Password;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (PassBox.PasswordContainer.Text == pass)
            {
                Accepted = true;
                Close();
            }
        }


        public new void Show()
        {
            ShowDialog();
        }
    }
}
