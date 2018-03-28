using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheretence
{
    class Dog : Animal
    {
        public int Age { get; set; }

        public Dog(string name, string sound, int age)
            :base(name, sound)
        {
            Age = age;
        }

        public void dogGreets()
        {
            MessageBox.Show("Dog Info: " + "\nName: " + Name + "\nSound: " + Sound + "\nAge: " + Age, "Dog Class!");
        }
    }
}
