using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week3_ProProb2
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


        private void calculateButton_Click(object sender, EventArgs e)
        {
            double purchasePrice, stateTax, countyTax, totalSalesTax, totalOfSale, total;

            purchasePrice = double.Parse(textBox1.Text);

            stateTax = 0.04;
            label6.Text = stateTax.ToString("P");

            countyTax = 0.02;
            label7.Text = countyTax.ToString("P");

            totalSalesTax = stateTax + countyTax;
            label9.Text = totalSalesTax.ToString("P");

            totalOfSale = purchasePrice * totalSalesTax;
            label8.Text = totalOfSale.ToString("c2");

            total = purchasePrice + totalSalesTax;
            label9.Text = total.ToString("c2");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
