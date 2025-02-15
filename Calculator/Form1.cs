using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            if (txtsoa.Text !=String.Empty)
            {
                a = int.Parse(txtsoa.Text);
                b = int.Parse(txtsob.Text);
                kq = a + b;
                //txtkq.Text = (a + b).ToString();
                txtkq.Text = kq.ToString(); 
            }
        }
    }
}
