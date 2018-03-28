using System;
using System.Windows.Forms;
using System.Text;

namespace Scott_Week8_Project1
{
    public partial class Form1 : Form
    {
        private string str;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assigning the string to the textbox
            str = textBox1.Text;
            //Output the string to label2 and covert it to upper case.
            label2.Text = str.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Assigning the string to the textbox
            str = textBox1.Text;
            //Output the string to label2 and covert it to lower case.
            label2.Text = str.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Assigning the string to the textbox
            str = textBox1.Text;
            //Output the string to label2 and covert it to upper case.
            label2.Text = str.Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;

            //Uppercase variable.
            int upperCase = 0;

            //Loop through the string str us (uppercase) is a variable of the char type.
            foreach (char uc in str)
            {
                //If uc char find
                if (char.IsUpper(uc))
                {
                    //Thne increase upperCase var by 1
                    upperCase++;
                }
                label2.Text = upperCase.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;

            int lowerCase = 0;

            foreach (char lc in str)
            {
                if (char.IsLower(lc))
                {
                    lowerCase++;
                }
                label2.Text = lowerCase.ToString();
            }
        }
    }
}
