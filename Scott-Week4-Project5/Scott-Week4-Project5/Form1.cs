using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Parse method converts string to a numeric value.
            int i = Int32.Parse(textBox1.Text);
            MessageBox.Show(i + ", is converted from a string to a number.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*TryParse method returns the actual value if the conversion from a string to nuneric is successful.
             * It returns 0 if the conversion is unsuccessful.*/
            string str = (textBox2.Text);
            int result = 0;
            int.TryParse(str, out result);
            MessageBox.Show("The conversion value is: " + result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
