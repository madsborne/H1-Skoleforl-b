using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPrimeNumbers
{
    class QueueControl
    {
        Queue<int> primeNumbers = new Queue<int>();

        public QueueControl()
        {
            primeNumbers.Enqueue(2);
            primeNumbers.Enqueue(3);
            primeNumbers.Enqueue(5);
            primeNumbers.Enqueue(7);
            primeNumbers.Enqueue(11);
        }

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
