using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrimeNumbers
{
    class QueueControl
    {
        // creating a queue called primeNumbers
        Queue<int> primeNumbers = new Queue<int>();

        // adding prime numbers into the que in the con
        public QueueControl()
        {
            primeNumbers.Enqueue(2);
            primeNumbers.Enqueue(3);
            primeNumbers.Enqueue(5);
            primeNumbers.Enqueue(7);
            primeNumbers.Enqueue(11);
        }

        /// <summary>
        /// method that displays the numbers that are in the queue 
        /// </summary>
        public void PrimeNumberPrint()
        {
            while (primeNumbers.Count > 0)
            {
                int number = primeNumbers.Dequeue();

                Console.WriteLine(number);
            }
        }
    }
}
