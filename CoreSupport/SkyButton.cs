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
    public partial class SkyButton : Button
    {
        public Color DefaultColor { get; set; } = SystemColors.Highlight;
        public Color Hover { get; set; }
        public SkyButton()
        {
            InitializeComponent();
        }

        private void SkyButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Hover;
        }

        private void SkyButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultColor;
        }
    }
}
