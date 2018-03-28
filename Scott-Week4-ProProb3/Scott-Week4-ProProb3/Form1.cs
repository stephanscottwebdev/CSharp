using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week4_ProProb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton4.Checked)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            if (radioButton1.Checked && radioButton5.Checked)
            {
                this.BackColor = System.Drawing.Color.Purple;
            }
            if (radioButton1.Checked && radioButton6.Checked)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            if (radioButton2.Checked && radioButton4.Checked)
            {
                this.BackColor = System.Drawing.Color.Purple;
            }
            if (radioButton2.Checked && radioButton5.Checked)
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            if (radioButton3.Checked && radioButton4.Checked)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                this.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
