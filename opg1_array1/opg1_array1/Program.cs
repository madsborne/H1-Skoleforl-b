using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1_array1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating my array
            int[] myArray = new int[10];

            // creating a for loop to add numbers to the array also adding the numbers to 
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 2;
            }
            // creaing a foreach loop to run through the numbers and checking to the numbers to find the number on index 5
            foreach (int myTarget in myArray)
            {
                if (myTarget == myArray[6])
                {
                    Console.WriteLine("you got it");
                }
                else
                {
                    Console.WriteLine("didnt happen");
                }
            }
        }
    }
}
