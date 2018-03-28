using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grade = double.Parse(textBox1.Text);

            if (grade >= 90)
            {
                label3.Text = "A";
            }
            else if (grade >= 80)
            {
                label3.Text = "B";
            }
            else if (grade >= 70)
            {
                label3.Text = "C";
            }
            else if (grade >= 60)
            {
                label3.Text = "D";
            }
            else
            {
                label3.Text = "F";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
