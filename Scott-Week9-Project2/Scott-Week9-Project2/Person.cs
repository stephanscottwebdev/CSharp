using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Week9_Project2
{
    class Person
    {
        private string newName;
        private double newHeight;
        private double newWeight;

        public Person()
        {
            //Default constructor.
        }

        //Overloaded constructor with 3 parameters.
        public Person(string Name, double Height, double Weight)
        {
            newName = Name;
            newHeight = Height;
            newWeight = Weight;
        }

        //Creating Accessors and Mutators (Getters & Setters)
        //Get method always return a value.
        //Get method must return a class field.
        public string getName()
        {
            return newName;
        }

        public double getHeight()
        {
            return newHeight;
        }

        public double getWeight()
        {
            return newWeight;
        }

        //Set is of the type Void.
        //In this case it has one parameter.
        //The parameter recieves an argument value to set.
        //The corresponding class field.
        public void setName(string name)
        {
            newName = name;
        }

        public void setHeight(double height)
        {
            newHeight = height;
        }

        public void setWeight(double weight)
        {
            newWeight = weight;
        }
    }
}
