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
            // calls the two methods 
            ArrayNumbers();
            // displays the returned number of how many numbers there are in the array
            Console.WriteLine("There are this many left in the list -> " + ListNumbers());
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
    
        static string ListNumbers()
        {
            // local vars & lists
            string numbers;
            List<int> evenNumbers = new List<int>
            {
                2,
                4,
                6,
                8,
                10,
                12,
                14,
                16,
                18,
                20
            };
            List<int> evenNumbersReversed = new List<int>();
            
            // loops through the list to check if any numbers are equal to Modolus 3 if they are
            // they are removed from the list
            for (int i = 0; i < evenNumbers.Count; i++)
            {
                if (evenNumbers[i] % 3 == 0)
                {
                    evenNumbers.RemoveAt(i);
                }
            }
            // Inserts the number 17 into the index 2 of the list 
            evenNumbers[2] = 17;

            // adds the numbers from the evenNumbers list into the evenNumbersReversed list and the below revers them 
            for (int j = 0; j < evenNumbers.Count; j++)
            {
                evenNumbersReversed.Add(evenNumbers[j]);
            }
            evenNumbersReversed.Reverse();

            // Debug if you wanna see it in action
            foreach (int number in evenNumbersReversed)
            {
               // Debug use if you wanna check that it works Console.WriteLine("This is from reversed numbers" + number);
            }

            // Converts the count into a string and then returns that string
            numbers = Convert.ToString(evenNumbers.Count);

            // returns the count of how many indexs there are left in the list
            return numbers;
        }

    }
}
