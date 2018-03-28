using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project6
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
            int[] source = { 1, 3, 4, 7, 9, 11, 15, 22, 30 };

            //Creating searchVaIue variable to hold the input of text30xI 
            int searchValue;

            //Converting string to an integer 
            int.TryParse(textBox1.Text, out searchValue);

            //Loading the array values on a label 
            label2.Text = string.Join(", ", source);

            //Using built in ainaySearch method inside Arra class 
            //Passing source integer array and searchVaIue to ainaySearch method 
            //Storing the return value of ainaySearch in result variable 
            int result = Array.BinarySearch(source, searchValue);

            //if the index of the elemnet searched > 
            if (result > 0)
            {
                //Display the element and its index 
                MessageBox.Show(searchValue + " exists at index: " + result.ToString());
            }
            else
            {
                //if the index < then the element not found 
                MessageBox.Show(searchValue + " does not exist! " + result.ToString());
            }
        }
    }
}
