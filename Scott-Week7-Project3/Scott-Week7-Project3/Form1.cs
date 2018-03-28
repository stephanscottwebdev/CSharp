using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week7_Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating am integer 2d array of 5 rows and 2 columns.
            int[,] arr2d = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            //Ouput each array elements value.
            for (int i = 0; i < 5; i++)
            {
                //Printing the elements of the 2d array.
                listBox1.Items.Add(arr2d[i, 0] + " , " + arr2d[i, 1]);
            }
        }
    }
}
