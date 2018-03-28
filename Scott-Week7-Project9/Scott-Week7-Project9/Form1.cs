using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> str = new List<string>();
            //List elements
            str.Add("Ali");
            str.Add("Michelle");
            str.Add("Same");
            str.Add("Tom");
            str.Add("Joe");
            str.Add("Allison");
            str.Add("Stephan");

            //Loop through the string
            for (int i = 0; i < str.Count; i++)
            {
                listBox1.Items.Add(str[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            //List elements
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(2);
            numbers.Add(12);
            numbers.Add(100);
            numbers.Add(65);

            //Loop through the string
            for (int i = 0; i < numbers.Count; i++)
            {
                listBox2.Items.Add(numbers[i]);
            }
        }
    }
}
