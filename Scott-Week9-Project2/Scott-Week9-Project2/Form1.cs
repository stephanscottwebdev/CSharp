using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week9_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create an instance of the Person class
            Person p1 = new Person();

            MessageBox.Show("Name: " + p1.getName() + "\nHeight: " + p1.getHeight() + "\nWeight: " + p1.getWeight());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name;
            double height;
            double weight;

            name = textBox1.Text;
            double.TryParse(textBox2.Text, out height);
            double.TryParse(textBox3.Text, out weight);

            //Object of the Person class.
            Person p1 = new Person();

            MessageBox.Show("Name: " + p1.getName() + "\nHeight: " + p1.getHeight() + "\nWeight: " + p1.getWeight());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name;
            double height;
            double weight;

            name = textBox1.Text;
            double.TryParse(textBox2.Text, out height);
            double.TryParse(textBox3.Text, out weight);

            //Object of the Person class.
            Person p1 = new Person(name, height, weight);
            Person p2 = new Person();

            //Calling setter methods in Person class.
            p2.setName("Alex Garcia");
            p2.setHeight(6.5);
            p2.setWeight(200);

            MessageBox.Show("Name: " + p1.getName() + "\nHeight: " + p1.getHeight() + "\nWeight: " + p1.getWeight());

            MessageBox.Show("Name: " + p2.getName() + "\nHeight: " + p2.getHeight() + "\nWeight: " + p2.getWeight());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
