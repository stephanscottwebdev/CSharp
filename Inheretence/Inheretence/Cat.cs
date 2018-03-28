using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheretence
{
    class Cat : Dog
    {
        public string HairColor { get; set; }

        public Cat(string name, string sound, int age, string haircolor)
            :base (name, sound, age)
        {
            HairColor = haircolor;
        }

        public void catGreets()
        {
            MessageBox.Show("Cat Info: " + "\nName: " + Name + "\nSound: " + Sound + "\nAge: " + Age + "\nHair Color: " + HairColor, "Cat Class!");
        }
    }
}
