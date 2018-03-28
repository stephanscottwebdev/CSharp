using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week3_ProProb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Fah;
            Fah = double.Parse(textBox1.Text);
            Fah = 9/5 C + 32;
            label3.Text = convertedFah.ToString("°");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Cel;
            Cel = double.Parse(textBox1.Text);
            Cel = 9 / 5 (F - 32);
            label4.Text = convertedCel.ToString("°");
        }
    }
}
