using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2;
            str1 = (textBox1.Text);
            str2 = (textBox2.Text);
            if (str1 == str2)
            {
                label3.Text = "Strings are equal";
                MessageBox.Show("Strings are equal");
            }
            else
            {
                label3.Text = "Strings are not equal";
                MessageBox.Show("Strings are not equal");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = (textBox1.Text);
            string str2 = (textBox1.Text);
            int result = string.Compare(str1, str2);
            label4.Text = result.ToString();
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
