using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheretence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.animalGreets();

            Dog d = new Dog("Rufus", "Woof", 5);
            d.dogGreets();

            Cat c = new Cat("Chibbs", "Meow", 3, "Grey");
            c.catGreets();
        }
    }
}
