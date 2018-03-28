using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week3_ProProb1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName;
            fullName = textBox4.Text + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            MessageBox.Show(fullName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstMidLast;
            firstMidLast = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            MessageBox.Show(firstMidLast);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string firstLast;
            firstLast = textBox1.Text + " " + textBox3.Text;
            MessageBox.Show(firstLast);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fullNameRev;
            fullNameRev = textBox3.Text + " " + textBox2.Text + " " + textBox1.Text +  " " + textBox4.Text;
            MessageBox.Show(fullNameRev);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string lastMidFirst;
            lastMidFirst = textBox3.Text + " " + textBox2.Text + " " + textBox1.Text;
            MessageBox.Show(lastMidFirst);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string lastAndFirst;
            lastAndFirst = textBox3.Text + " " + textBox1.Text;
            MessageBox.Show(lastAndFirst);
        }
    }
}
