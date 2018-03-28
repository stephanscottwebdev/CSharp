using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring row and column variables.
            int row, column;

            //Creating an integer 2D array of 3 rows and 3 columns.
            int[,] numbers = new int[3, 3]
            {
                { 24, 50, 60 },
                { 30, 25, 70 },
                { 10, 67, 29 }
            };

            //Inputing the row number
            int.TryParse(textBox1.Text, out row);
            //Inputing the column number
            int.TryParse(textBox2.Text, out column);

            //Selection statement.
            if (row == 0 && column == 0)
            {
                //Printing the element stored at row(n) and dolumn(n) on label 3
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 0 && column == 1)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 0 && column == 2)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 1 && column == 0)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 1 && column == 1)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 2 && column == 0)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 2 && column == 1)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else if (row == 2 && column == 2)
            {
                label3.Text = numbers[row, column] + ", is stored at row " + row + " and at column " + column;
            }
            else
            {
                //If you entered a number higher than 3 you get the message below.
                label3.Text = "Invalid row or column number, please enter a number between 1-3!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
