using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week8_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Hello Class!!!!";
            MessageBox.Show(str, "Before");

            //Inserting the word DMACC at index 5
            MessageBox.Show(str.Insert(5, " DMACC "), "After, with white spaces");

            //Without white spaces
            MessageBox.Show(str.Insert(5, "DMACC"), "After, without white spaces");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Hello Class!!!!";
            MessageBox.Show(str, "Before");

            //Remove all characters starting at index 11
            MessageBox.Show(str.Remove(11), "After");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Hello Class!!!!";
            MessageBox.Show(str, "Before");

            //Replace lower case l with an upper case L, all occurrences.
            MessageBox.Show(str.Replace("l", "L"), "After");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //The original string elements are seperated by a delimiter, ; is a delimiter to tell the split where to start/stop
            string names = "Ali;Tim;Ben;Sarah;Debra;Mike;John";
            MessageBox.Show(names, "Before");

            //Split method splits names array, elements produced are stored in namesArr[]
            string[] namesArr = names.Split(';');
            foreach (string newName in namesArr)
            {
                MessageBox.Show(newName, "After");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = "Stephan Scott";

            //Start at index 0 and stop at the first whitespace.
            string firstName = name.Substring(0, name.IndexOf(' '));

            //Start at the first whitespace and display everything after.
            string lastName = name.Substring(name.IndexOf(' '));

            MessageBox.Show(firstName);
            MessageBox.Show(lastName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = "                 Stephan Scott                  ";
            MessageBox.Show(name, "Without Trim");

            string myName = name.Trim();
            MessageBox.Show(myName, "With Trim");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str1 = "Scott";
            string str2 = "Stephan";

            //Join method joins strings, string comma seperator
            string name = string.Join(", ", str1, str2);
            MessageBox.Show(name);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string firstString = "DMACC";
            string secondString = "dmacc";

            //We use OrdinalIgnoreCase method in StringComparison class to ignore upper/lower case letters
            //If both strings match and the difference is only lower case then it returns true.
            if (firstString.Equals(secondString, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str1 = "abc";
            string str2 = "xyz";

            /* If str1 = str2, result = 0
             * if str1 > str2, result = 1
             * if str1 < str2, result = -1
             * When comparing strings the hexadecimal value of the character is compared and considered.
             * */
            int result = String.Compare(str1, str2);

            MessageBox.Show(result.ToString());
        }
    }
}
