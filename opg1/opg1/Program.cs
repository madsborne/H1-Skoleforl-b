using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            // giving the value 16 to the int a
            int a = 16;

            // giving a double the value of 5.1
            double b = 5.1;

            // trying to put the to vars into the int c but it wont since c is an int and i can't put b into since it's a double
            //int c = a + b;

            //this will work since you can put an int into a double but you can't put a double into an int
            double c = a + b;

            // prints out the resault of a + b
            Console.WriteLine(a + b);

            // outputs the double c
            Console.WriteLine(c);

            // it adds them together 
        }
    }
}
