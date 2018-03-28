using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Week3_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name.");
            //Reads and stores the first name into a cariable named "fn"
            string fn = Console.ReadLine();

            Console.WriteLine("Enter your last name.");

            string ln = Console.ReadLine();

            Console.WriteLine("Hello, " + fn + " " + ln);

            Console.WriteLine();

            Console.WriteLine("Enter your age: ");

            string str = Console.ReadLine();
            //Converts string "str" to double and stores that age as a variable
            double age = double.Parse(str);

            Console.WriteLine("Your age is: " + age + ", next year you'll be: " + ++age);

            Console.ReadLine();
        }
    }
}
