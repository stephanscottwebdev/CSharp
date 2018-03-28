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
            if (checkBox1.Checked)
            {
                MessageBox.Show("You chose to drink Coffee!");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("You chose to drink Tea!");
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("You chose to drink a Cappuccino!");
            }
            if (radioButton1.Checked)
            {
                MessageBox.Show("You chose to pay with a credit card.");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("You chose to pay with a debit card.");
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("You chose to pay with cash.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            radioButton3.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
