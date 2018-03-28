using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project1
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
            //Creating a string Array of size 4, index starts at 0
            string[] str = { "Ali", "Adam", "Mike", "Sarah", "Susane" };

            //for loop to loop through the array elements
            for (int i = 0; i < str.Length; i++)
            {
                //Loads array elements into the listbox1
                listBox1.Items.Add(str[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creating an integer array
            int[] numbers = { 11, 22, 33, 44, 55, 66 };

            //Using a foreach loop to loop through the array
            foreach (int i in numbers)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[6];

            //Random class to populate the array, rand is an object of the Random class.
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                listBox2.Items.Add(rand.Next(20));
            }
        }
    }
}
