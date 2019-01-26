using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // a for loop counting to 100 if it's below 50 it will print it to the console when it goes above it won't write anything to the console
            for (int i = 0; i < 100; i++)
            {
                if (i < 51)
                {
                    Console.WriteLine(i); 
                }
            }
            for (int j = 100; j >= 0; j--)
            {
                Console.WriteLine(j);
            }
        }
    }
}
