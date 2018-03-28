using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_ProProb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amountPurchased = double.Parse(textBox1.Text);

            if (amountPurchased >= 4)
            {
                label4.Text = "60 Points!";
            }
            if (amountPurchased == 3)
            {
                label4.Text = "30 Points!";
            }
            if (amountPurchased == 2)
            {
                label4.Text = "15 Points!";
            }
            if (amountPurchased == 1)
            {
                label4.Text = "5 Points!";
            }
            if (amountPurchased == 0)
            {
                label4.Text = "0 Points!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = "";
        }
    }
}
