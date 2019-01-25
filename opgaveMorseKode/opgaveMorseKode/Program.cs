using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgaveMorseKode
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userInput;
            string convertedText = "";
            bool keepGoing = true;

            while (keepGoing == true)
            {
                userInput = Console.ReadKey();
                switch (userInput.KeyChar)
                {
                    case 'a':
                        convertedText += " .- ";
                        break;
                    case 'b':
                        convertedText += " -... ";
                        break;
                    
                }
                Console.WriteLine(convertedText);
                
            }
        }
    }
}

