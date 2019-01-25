using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcomes the user and gives them instructions on what is going and what this console application is for
            Console.WriteLine("Welcome to this converter type in the number you want to convert to Fahrenheit and Reamur");
            // parses the user input into a double 
            double celcius = Int32.Parse(Console.ReadLine());

            // here we start doing the math by using the celcius double and multiply it with the math used for the convertion
            double reamur = celcius * 0.8;
            double fahrenheit = celcius * 1.8 + 32;

            // outputs the result to the user
            Console.WriteLine("Okay Fahrenheit is " + fahrenheit);
            Console.WriteLine("and Reamur is " + reamur);

            // makes sure the application on close even though i normaly use ctrl + f5 for testing
            Console.ReadKey();
        }
    }
}
