using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class House
    {
        GumDispenser dispenser = new GumDispenser();

        public void PrintInfo()
        {
            // Tester
            foreach (Gum gum in dispenser.gumList)
            {
                Console.WriteLine(gum.Flavor);
                
            }
            Console.WriteLine(dispenser.gumList.Count);

            
        }
    }
}
