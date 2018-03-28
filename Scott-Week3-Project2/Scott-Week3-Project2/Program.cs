using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Week3_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2500;

            //format i as a currency and assign it to the str variable
            string str = i.ToString("c");
            Console.WriteLine(str);
            //formats i as currency with 3 decimal places
            str = i.ToString("c3");
            Console.WriteLine(str);
            Console.WriteLine();

            //formats i as a number and assigns it to the str variable
            str = i.ToString("n");
            Console.WriteLine(str);
            //number with no decimal places
            str = i.ToString("N0");
            Console.WriteLine(str);
            Console.WriteLine();

            //format i as a percentage and assigns it to str variable
            str = i.ToString("p");
            Console.WriteLine(str);
            //reads and holds the terminal
            Console.ReadLine();
        }
    }
}
