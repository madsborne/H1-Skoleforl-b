using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancing a random
            Random rnd = new Random();

            // saving the random number
            int rndNumber = rnd.Next(1, 7);

            // one huge statement that checks the number and tells me what i landed on
            if (rndNumber == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("you rolled number 1");
            }
            else if (rndNumber == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you rolled number 2");
            }
            else if (rndNumber == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you rolled number 3");
            }
            else if (rndNumber == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("you rolled number 4");
            }
            else if (rndNumber == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("you rolled number 5");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("you rolled number 6");
            }

            // make sure the program doesn't close
            Console.ReadKey();
        }
    }
}
