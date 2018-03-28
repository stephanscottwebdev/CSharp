using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letterGrade = (textBox1.Text);

            switch (textBox1.Text)
            {
                case "A":
                    label3.Text = "You recieved an A, great job!";
                    break;
                case "B":
                    label3.Text = "You recieved an B, great job!";
                    break;
                case "C":
                    label3.Text = "You recieved an C, great job!";
                    break;
                case "D":
                    label3.Text = "You recieved an D, great job!";
                    break;
                case "F":
                    label3.Text = "You recieved an F, I'm sorry but you failed.";
                    break;
                default:
                    label3.Text = "Invalid entry, please enter A, B, C, D or F";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
