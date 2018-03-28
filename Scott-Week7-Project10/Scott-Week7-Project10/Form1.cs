using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>() { 7, 8, 9, 2, 3, 4, 5, 1, 15 };
            //Title
            listBox1.Items.Add("Original");
            //Loop through the list
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox1.Items.Add(numbers[i]);
            }
            //Title
            listBox2.Items.Add("Sorted");
            //Sorting the list
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                listBox2.Items.Add(numbers[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> numbers = new List<string>() { "Ali", "Adam", "Tim", "Pam", "Xavier", "John", "Dave" };

            listBox3.Items.Add("Original");
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox3.Items.Add(numbers[i]);
            }

            listBox4.Items.Add("Sorted");
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox4.Items.Add(numbers[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>() { 7, 8, 9, 2, 3, 4, 5, 1, 15 };
            //Title
            listBox1.Items.Add("Original");
            //Loop through the list
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox1.Items.Add(numbers[i]);
            }
            //Title
            listBox2.Items.Add("Reversed");
            //Sorting the list
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                listBox2.Items.Add(numbers[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> numbers = new List<string>() { "Ali", "Adam", "Tim", "Pam", "Xavier", "John", "Dave" };

            listBox3.Items.Add("Original");
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox3.Items.Add(numbers[i]);
            }

            listBox4.Items.Add("Reversed");
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox4.Items.Add(numbers[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
