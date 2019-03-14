using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vending = new VendingMachine();

            // Testing
            foreach (Candy candy in vending.vendingSlots[0])
            {
                Console.WriteLine(candy.Name);
            }
        }
    }
}
