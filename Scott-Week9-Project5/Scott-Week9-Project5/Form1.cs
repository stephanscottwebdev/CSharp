using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week9_Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName, lastName;
            firstName = textBox1.Text;
            lastName = textBox2.Text;

            //Instance of class Form 2
            Form2 f2 = new Form2(firstName, lastName);
            //Show method in Form 2 to display Form 2
            f2.Show();
        }
    }
}
