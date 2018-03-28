using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week8_Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            //str stores the input of textbox1
            str = textBox1.Text;
            //id the input string contains the word DMACC
            if (str.Contains("DMACC"))
            {
                //Then display
                MessageBox.Show("The sequence 'DMACC' was found in " + str);
            }
            else
            {
                //If not, then display. Escape sequence char used to display " "
                MessageBox.Show("The word \"DMACC\" not found in " + str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Formatting phone nuumber
            MessageBox.Show(string.Format("My phone number: " + "{0:(###) ###-####}", 5159646461));
            //Formatting date
            MessageBox.Show(string.Format("{0:yyyy-dd-MM T HH:mm:ss:000}", DateTime.Now));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str;

            str = textBox1.Text;

            //In substring we extract a fragment of an existing string, here we skip the first 2 char and display the rest.
            string substr = str.Substring(2);
            MessageBox.Show(str + ", skip the first two letters, " + substr);

            //Start after the second char and display 5 after.
            substr = str.Substring(3, 5);
            MessageBox.Show(str + ", start after the 3rd character and display 5 after, " + substr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;

            //Creating a letter  variable of hte type char
            char letter;

            for (int index = 0; index < str.Length; index++)
            {
                //Assigning the string str char to letter variable.
                letter = str[index];
                MessageBox.Show(letter.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;

            if (str.StartsWith("ab"))
            {
                MessageBox.Show("True");
                MessageBox.Show(str + ", does not start with \"ab\"");
            }
            else
            {
                MessageBox.Show("False");
                MessageBox.Show(str + ", does not start with \"ab\"");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;

            if (str.EndsWith("eam"))
            {
                MessageBox.Show("True");
                MessageBox.Show(str + ", does not end with \"eam\"");
            }
            else
            {
                MessageBox.Show("False");
                MessageBox.Show(str + ", does not start with \"eam\"");
            }
        }
    }
}
