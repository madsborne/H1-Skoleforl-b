using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg2_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user for an two inputs
            Console.WriteLine("Type in two numbers to find out which is biggest");

            Console.WriteLine("type in the first number");
            // takes the input from the first number
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("type in the second number");
            // takes the input from the second number
            int n2 = Int32.Parse(Console.ReadLine());
            
            // takes the two numbers and does the math and puts it into the var n3
            int n3 = n1 ^ 2 + n2 ^ 2;

            // outputs the result and also finding out which number was bigger
            if (n1 > n2)
            {
                Console.WriteLine("the first number was bigger");
                Console.WriteLine("also your number was " + n3);
            }
            // if n1 isn't bigger it goes down to the else and tells me n2 was bigger
            else
            {
                Console.WriteLine("the second number was bigger");
                Console.WriteLine("also your number was " + n3);
            }
        }
    }
}
