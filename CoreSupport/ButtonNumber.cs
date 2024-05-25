using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopSupport
{
    public partial class ButtonNumber : UserControl
    {
        public double Value 
        { 
            get 
            {
                double Decimal;
                double.TryParse(DecimalAdd.Text, out Decimal);

                DecimalAdd.Text = Decimal.ToString();

                return Decimal;
            } 
            set 
            {
                DecimalAdd.Text = value.ToString();
            }
        }
        public double IncrementVar { get; set; } = 1;
        public double DecrementVar { get; set; } = 1;

        public ButtonNumber()
        {
            InitializeComponent();
        }

        private void DecimalAdd_TextChanged(object sender, EventArgs e)
        {
            double Decimal;
            double.TryParse(DecimalAdd.Text, out Decimal);

            DecimalAdd.Text = Decimal.ToString();
        }

        private void Increment_Click(object sender, EventArgs e)
        {
            Value += IncrementVar;
        }

        private void Decrement_Click(object sender, EventArgs e)
        {
            Value -= DecrementVar;
        }
    }
}
