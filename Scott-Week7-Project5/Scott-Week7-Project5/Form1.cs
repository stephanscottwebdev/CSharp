using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating an integer array.
            int[] intArray = { 2, 4, 5, 6, 3, 8, 9, 0, 1, 21, 23, 15, 12, 6, 7, 10, 14, 17 };

            //Join method in string class is a string seperator.
            label3.Text = string.Join(", ", intArray);

            try
            {
                //Converting string to int and storing it in the guess variable.
                int guess = int.Parse(textBox1.Text);
                //Loop counter
                int i = 0;

                //While loop compares the number entered in textbox1 to the array elements, if th enumber entered is not an element, the loop continues.
                while (i < intArray.Length && guess != intArray[i])
                {
                    i++;
                }

                if (i < intArray.Length)
                {
                    MessageBox.Show("Number " + intArray[i] + ", exists at index: " + i);
                }
                else
                {
                    MessageBox.Show("Number " + guess + " doesn't exist!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input, enter an integer!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] strArray = { "Ali", "Bob", "Fiona", "Sarah", "Jack", "Julie", "Matt", "Sue", "Mariam" };
            label3.Text = string.Join(", ", strArray);
            try
            {
                string guessStr = textBox2.Text;
                int i = 0;

                while (i < strArray.Length && guessStr != strArray[i])
                {
                    i++;
                }
                if (i < strArray.Length)
                {
                    MessageBox.Show("Name " + strArray[i] + ", exsists at index: " + i);
                }
                else
                {
                    MessageBox.Show("Name " + guessStr + " doesn't exist!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input, enter a name!");
            }
        }
    }
}
