using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an integer array named salaries with 5 elements.
                int[] salaries = { 10000, 25000, 60000, 80000, 55000 };

                //Declare a StreamWriter variable.
                StreamWriter sw;

                //Create Salary.txt file and get a StreamWriter object.
                sw = File.CreateText("Salary.txt");

                //Write the array's elements to the Salaries.txt file
                for (int index = 0; index < salaries.Length; index++)
                {
                    sw.WriteLine(salaries[index]);

                    listBox1.Items.Add(salaries[index]);
                }

                //Close the file.
                sw.Close();

                //Let the user know it's done.
                MessageBox.Show("Salaries are written to the Salary.txt file." + "\n\nSalary.txt is located in the bin\\Debug folder.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an array to hold 5 elements. Like the 5 salaries from the write file.
                int[] numbers = new int[5];

                //Set the counter variable to use in the loop statement.
                int index = 0;

                StreamReader sr;

                //Open the file and get the StreamReader object.
                sr = File.OpenText("Salary.txt");

                //Read the files contents into an array.
                while (index < numbers.Length && !sr.EndOfStream)
                {
                    numbers[index] = int.Parse(sr.ReadLine());
                    index++;
                }

                sr.Close();

                //Display the array elements in the listbox.
                foreach (int i in numbers)
                {
                    listBox2.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
