using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week6_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void byValue(int Age)
        {
            Age = Age + 5;
        }

        void byReference(ref int Age)
        {
            Age = Age + 5;
        }

        void byOutput(ref int Age, out string Name, out double Salary)
        {
            Age = Age + 5;
            Name = "Stephan Scott";
            Salary = 75000.00;
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(tbAge.Text);
                byValue(age);

                MessageBox.Show("Your age is: " + age.ToString() +
                    "\nYou are passing an argument by value." +
                    "\nA copy of the variable is passed" +
                    "\nTwo different memory locations");
            }
            catch
            {
                MessageBox.Show("Invalid input, please enter an interger!");
            }
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(tbAge.Text); //age = age+5
                byReference(ref age);

                MessageBox.Show("Your age is: " + age.ToString() +
                    "\nYou are passing an argument by reference." +
                    "\nThe variable is modified." +
                    "\nSame memory location.");
            }
            catch 
            {
                MessageBox.Show("Invalid input, please enter an interger!");
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(tbAge.Text);
                string name;
                double salary;
                byOutput(ref age, out name, out salary);

                MessageBox.Show("Your age is: " + age.ToString() +
                    "\nYou are passing an output argument." +
                    "\nIt is similar to pass by reference." +
                    "\nThe name passed as an output is: " + name +
                    "\nThe salary passed as an output is: " + salary);
            }
            catch 
            {
                MessageBox.Show("Invalid input, please enter an interger!");
            }
        }
    }
}
