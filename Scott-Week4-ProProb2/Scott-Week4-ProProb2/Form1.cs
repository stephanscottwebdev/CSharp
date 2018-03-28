using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_ProProb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(textBox1.Text);
            
            if (weight >= 1000)
            {
                label2.Text = "That is too heavy.";
            }
            else if (weight >= 10)
            {
                label2.Text = "That is too light.";
            }
        }
    }
}
