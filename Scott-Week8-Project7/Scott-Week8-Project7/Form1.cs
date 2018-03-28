using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week8_Project7
{
    public partial class Form1 : Form
    {
        //Declare a global variable i represents an index of an image in the Images[] array
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //If i is < the images count in the imageList then
            if (i < imageList1.Images.Count)
            {
                //Put an image in the images array and add it to the picturebox
                pictureBox1.Image = imageList1.Images[i];

                i++;

                label1.Text = "Image: " + i;
            }
            else
            {
                //When i = imageList1.Images.Count, reset i to 0, this will make a continuous loop
                i = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
