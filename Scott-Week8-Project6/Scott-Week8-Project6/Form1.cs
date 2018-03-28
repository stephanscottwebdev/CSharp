using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week8_Project6
{
    public partial class Form1 : Form
    {
        enum weekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Use GetName method in the Enum class to get enum elements
            //Store the enum elements in the Values string array
            string[] Values = (string[])Enum.GetNames(typeof(weekDays));
            //Loop through the Values string array
            foreach (object i in Values)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Use GetValues method
            int[] Numbers = (int[])Enum.GetValues(typeof(weekDays));
            foreach (int i in Numbers)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create an instance of enum weekDays to access one element
            weekDays wd = weekDays.Monday;
            //Creating another
            weekDays wd1 = weekDays.Friday;
            MessageBox.Show(wd.ToString());
            MessageBox.Show(wd1.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (weekDays wd in Enum.GetValues(typeof(weekDays))) 
            {
                MessageBox.Show(wd.ToString());
            }
        }
    }
}
