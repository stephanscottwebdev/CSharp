using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week9_Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            double height;
            double weight;

            name = textBox1.Text;
            double.TryParse(textBox2.Text, out height);
            double.TryParse(textBox3.Text, out weight);

            Person p1 = new Person(name, height, weight);
            //Calling the default constructor
            Person p2 = new Person();

            //Calling setters
            p2.personName = "Alex Garcia";
            p2.personHeight = 6.5;
            p2.personWeight = 200;

            MessageBox.Show("Name: " + p1.personName + "\nHeight: " + p1.personHeight + "\nWeight: " + p1.personWeight);
            MessageBox.Show("Name: " + p2.personName + "\nHeight: " + p2.personHeight + "\nWeight: " + p2.personWeight);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
