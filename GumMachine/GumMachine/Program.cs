using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates my house which stores the dispenser 
            House myHouse = new House();
            string returnedInfo = "";

            while (true)
            {
                Console.WriteLine("Welcome to the Gum Dispenser");
                Console.WriteLine("1: Pull the lever to get a piece of gum");
                Console.WriteLine("2: Refill the Dispenser");

                switch (Console.ReadLine())
                {
                    case "1":
                        returnedInfo = myHouse.PullGum();
                        Console.WriteLine(returnedInfo);
                        break;
                    case "2":
                        returnedInfo = myHouse.RefillMachine();
                        Console.WriteLine(returnedInfo);
                        break;
                    case "3":
                        
                        break;

                    default:
                        break;
                } 
            }
        }

        
    }
}
