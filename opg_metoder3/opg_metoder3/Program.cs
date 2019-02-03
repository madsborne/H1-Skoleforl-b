using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_metoder3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayNumbers();
        }

        static void ArrayNumbers()
        {
            // my array that holds from 0 - 9 
            int[] myArray = new int[10];

            // my for loop that adds numbers into the array and then if it spots index 5 it will double that number and then adds it to the array 
            for (int i = 1; i < myArray.Length; i++)
            {
                myArray[i] = i;
                if (myArray[i] == 6)
                {
                    myArray[6] = i * 2;
                }
                // Debug // Console.WriteLine(myArray[i]);
            }
        }
    
        static void ListNumbers()
        {
            List<int> 
        }

    }
}
