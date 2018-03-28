using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Week9_Project3
{
    class Person
    {
        private string newName;
        private double newHeight;
        private double newWeight;

        public Person()
        {

        }

        public Person(string Name, double Height, double Weight)
        {
            newName = Name;
            newHeight = Height;
            newWeight = Weight;
        }

        public string personName
        {
            get { return newName; }
            set { newName = value; }
        }

        public double personHeight
        {
            get { return newHeight; }
            set { newHeight = value; }
        }

        public double personWeight
        {
            get { return newWeight; }
            set { newWeight = value; }
        }
    }
}
