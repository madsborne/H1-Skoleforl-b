using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new obj of my QueueControl
            QueueControl queue = new QueueControl();

            // using the method from the queue obj
            queue.PrimeNumberPrint();
        }
    }
}
