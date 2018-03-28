using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project7
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
            int[] source = { 1, 3, 25, -1, 4, 45, 33, 10, 50, 78, 7, 59, 11, 15, 22, 30 };

            //sort the array in case it is not sorted 
            Array.Sort(source);

            //Loading the array values on a label 
            label2.Text = string.Join(", ", source);

            //Creating searchVaIue variable to hold the input of textBox1 
            int searchValue;

            //Converting string to an integer 
            int.TryParse(textBox1.Text, out searchValue);

            //Display if the element exists or not 
            // -I index means the element does not exist 
            MessageBox.Show(searchValue + ", found at index: " + binarySearch(source, searchValue));
        }

        // binarySearch method 
        //Has parameters an int array sourcel and and int searchVaIueI 
        public static int binarySearch(int[] source1, int searchValue1) 
            {
        // The middle index 
        int midIndex;
        // The first index 
        int leftIndex = 0;
        // The last index 
        int rightIndex = source1.Length;

            while (leftIndex <= rightIndex)
            {
                //midlndex is the middle index of the array 
                midIndex = (leftIndex + rightIndex) / 2;

                //if the midlndex = searchVaIue, then 
                if (source1[midIndex] == searchValue1)
                {
                    return midIndex;
                }
                else
                {
                    if (source1[midIndex] > searchValue1)
                    {
                        //Push the midlndex one place to the left
                        rightIndex = midIndex - 1;
                    }
                    else
                    {
                        //Shift the midlndex to the right 
                        leftIndex = midIndex + 1;
                    }
                }
            }
        // -1 indicates that the element does not exist 
        return -1; 
        }
    }
}
