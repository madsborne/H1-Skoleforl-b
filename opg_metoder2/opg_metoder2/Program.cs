using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_metoder2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Runs the Loop method
            NumberLoop();
        }

        // Didnt quite understand the 3 asignment 
        static void NumberLoop()
        {
            // two forloops that runes 1-10 and 10-1
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }

        }

        
    }
}
