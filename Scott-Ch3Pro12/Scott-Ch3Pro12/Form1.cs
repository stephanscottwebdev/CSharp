using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Ch3Pro12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double squareFoot, gallonPrice, gallonsNeeded, hoursNeeded, paintCost, laborCost, totalCost;

            squareFoot = double.Parse(textBox1.Text);
            gallonPrice = double.Parse(textBox2.Text);

            gallonsNeeded = squareFoot / 115;
            label8.Text = gallonsNeeded.ToString();

            hoursNeeded = gallonsNeeded * 8;
            label9.Text = hoursNeeded.ToString();

            paintCost = gallonPrice * gallonsNeeded;
            label10.Text = paintCost.ToString("c2");

            laborCost = hoursNeeded * 20;
            label11.Text = laborCost.ToString("c2");

            totalCost = paintCost + laborCost;
            label12.Text = totalCost.ToString("c2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
