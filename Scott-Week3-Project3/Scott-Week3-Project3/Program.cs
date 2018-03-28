using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Week3_Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implicit data conversion is done byu the complier automatically when converting a smaller
             * datatype like int to a larger datatype like float with no data loss.
             */
            int i = 200;
            float f = i;
            Console.WriteLine(f);

            /*Explicit conversion is done by the programmer when converting big datatpyes to smaller datatypes. 
            method 1 using typecast operator ()
            method 2 using convert class
            method 3 using Parse function
            */
            float f1 = 45.238f;
            //conversion using typecast operator (), method 1
            //converting a float to in, notice the loss of the decimal point
            int x = (int)f1;
            Console.WriteLine(x);

            //using convert class, method 2
            x = Convert.ToInt32(f1);
            Console.WriteLine(x);

            //using Parse method to convert a string to int, method 3
            string str = "1000";
            x = int.Parse(str);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
