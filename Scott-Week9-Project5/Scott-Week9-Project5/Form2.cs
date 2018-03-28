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
    public partial class Form2 : Form
    {

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        public Form2(string fn, string ln)
        {
            InitializeComponent();
            label1.Text = "Hello, " + fn + " " + ln;
        }
    }
}
