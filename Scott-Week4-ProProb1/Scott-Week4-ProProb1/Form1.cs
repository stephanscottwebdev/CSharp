using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_ProProb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = (textBox1.Text);

            switch (textBox1.Text)
            {
                case "1":
                    label2.Text = "I";
                    break;
                case "2":
                    label2.Text = "II";
                    break;
                case "3":
                    label2.Text = "III";
                    break;
                case "4":
                    label2.Text = "IV";
                    break;
                case "5":
                    label2.Text = "V";
                    break;
                case "6":
                    label2.Text = "VI";
                    break;
                case "7":
                    label2.Text = "VII";
                    break;
                case "8":
                    label2.Text = "VIII";
                    break;
                case "9":
                    label2.Text = "IX";
                    break;
                case "10":
                    label2.Text = "X";
                    break;
                default:
                    label2.Text = "Invalid entry, keep within 1-10.";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }
    }
}
