using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week8_Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool validSocialSecurityNumber (string str)
        {
            bool valid = true;

            //if the input = 9
            if (str.Length == 9)
            {
                //Loop through
                foreach (char c in str)
                {
                    //If its not a digit
                    if (!char.IsDigit(c))
                    {
                        //Then set valid to false
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        private void socialFormat(ref string str)
        {
            //Insert at index 3 "-"
            str = str.Insert(3, "-");
            //Insert at index 6 "-"
            str = str.Insert(6, "-");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1;

            //Trim to remove leading and trailing white spaces
            str1 = textBox1.Text.Trim();

            /*Calling validSocialSecurityNumber method through if statement
             * then passing the str1 variable to validSocialSecurityNumber method, 
             * it then ensures that every input is valid and has 9 digits.
            */
            if (validSocialSecurityNumber(str1))
            {
                //Calling socialFormat to format the SSN, passing str1 by ref
                socialFormat(ref str1);
                MessageBox.Show(str1);
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }
    }
}
