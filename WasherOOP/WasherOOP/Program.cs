using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // keeps the program running
            while (true)
            {
                // creating a new washing machine and naming it machine
                WashingMachine machine = new WashingMachine();

                // asks the user what washing mode they wanna run
                Console.WriteLine("What washing mode do you wanna select?");
                Console.WriteLine("1: Eco mode ");
                Console.WriteLine("2: Normal mode ");

                // runs the machine.Menu method 
                machine.Menu(Console.ReadLine());
            }
        }
    }
}
