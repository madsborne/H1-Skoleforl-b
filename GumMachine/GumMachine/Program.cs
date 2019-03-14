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
            House myHouse = new House();

            while (true)
            {
                Console.WriteLine("Welcome to the Gum Dispenser");
                Console.WriteLine("1: Pull the lever to get a piece of gum");

                switch (Console.ReadLine())
                {
                    case "1":
                        myHouse.PrintInfo();
                        break;

                    default:
                        break;
                } 
            }
        }

        
    }
}
