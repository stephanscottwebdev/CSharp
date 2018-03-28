using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating an integer array 
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };

            //Title
            listBox1.Items.Add("Original");

            //Loading the elements of the array using for loop 
            for (int i = 0; i < intArray.Length; i++)
            {
                //Displaying unsorted elements in listboxl 
                listBox1.Items.Add(intArray[i]);
            }
            //Title
            listBox2.Items.Add("Sort");
            //Using for loop to load the sorted elements 
            for (int x = 0; x < intArray.Length; x++)
            {
                //Llsing sort method in Array class to sort the array 
                Array.Sort(intArray);

                //Displaying sorted elements in list30x2 
                listBox2.Items.Add(intArray[x]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creating the temp variable
            int temp;
            //Integer array.
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
            //Title
            listBox3.Items.Add("Bubble");

            //Outer loop loops through the array elements.
            for (int i = 0; i <= intArray.Length; i++)
            {
                //Inner loop compares the adjacent elements.
                for (int j = 0; j <= intArray.Length - 2; j++)
                {
                    //If the element to the left is greater than the element to the right.
                    if (true)
                    {
                        //Store the element to the right temp variable.
                        temp = intArray[j + 1];
                        //Swap, replace the left element with the right.
                        intArray[j + 1] = intArray[j];
                        //Assign the temp value to the element on the left.
                        intArray[j] = temp;
                    }
                    
                }
            }
            //This for loop displays the sorted elements.
            for (int i = 0; i < intArray.Length; i++)
            {
                listBox3.Items.Add(intArray[i]);
            }
        }
    }
}

