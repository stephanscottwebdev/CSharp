using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week6_Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String fullName(string first, string middle, string last)
        {
            //Concatenating strings
            string Name = first + " " + middle + " " + last;
            return Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName, middleName, lastName, YourFullName;
            firstName = textBox1.Text;
            middleName = textBox2.Text;
            lastName = textBox3.Text;

            //Passing arguments to fullName method
            YourFullName = fullName(firstName, middleName, lastName);

            label4.Text = YourFullName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
