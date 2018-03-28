using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week2_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declaring variables
            double hoursWorked, payRate, grossPay;
            //Any value entered is taken as a string
            //Converting string to a double - method1
            hoursWorked = Convert.ToDouble(textBox1.Text);
            //method2
            payRate = double.Parse(textBox2.Text);
            //Calculates Gross Pay
            grossPay = hoursWorked * payRate;
            //Converts number entered in textbox2 into currency
            textBox2.Text = payRate.ToString("c");
            //Lable outputs strings, have to convert the double into a string, C means currency
            label4.Text = grossPay.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear textbox1
            textBox1.Text = "";
            //Clear textbox2
            textBox2.Text = "";
            //Clear label4
            label4.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }
    }
}
