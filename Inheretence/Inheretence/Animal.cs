using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheretence
{
    class Animal
    {
        public string Name { get; set; }

        public string Sound { get; set; }

        public Animal()
        {
                
        }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public void animalGreets()
        {
            MessageBox.Show("Default Constructor of the Animal Class!" + "\nName: " + Name + "\nSound: " + Sound, "Animal Class!");
        }
    }
}
