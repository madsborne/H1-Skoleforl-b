using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_arrays_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            // a loop that keeps the program running
            while (true)
            {
                // asks the user for a input
                Console.WriteLine("Hello user to see each of the different homework please type in a number to go that part of the program");
                Console.WriteLine("Type 1 - opg A - Array with 100 random numbers from 0 to 1000");
                Console.WriteLine("Type 2 - opg B and C - Bubblesort and build in reverse");
                Console.WriteLine(Menu(Console.ReadLine()));
            }
        }

        // a menu that takes in the user input and navigates around
        static string Menu(string userInput)
        {
            // switch that takes in the userinput and then if the user typed correct starts the method in the given case
            string menuReturn = "";
            switch (userInput)
            {
                case "1":
                    foreach (int number in RandomArray())
                    {
                        Console.WriteLine(number);
                    }
                    break;
                case "2":
                    Bubblesort();
                    break;

                default:
                    menuReturn = "Not a valid input";
                    break;
            }
            return menuReturn;
        }

        /// <summary>
        /// Creates an array of a 100 and then puts in 100 random numbers and then returns the array
        /// </summary>
        /// <returns></returns>
        static int[] RandomArray()
        {
            // local vars
            int[] randomNumbers = new int[100];
            Random rnd = new Random();
            int randomNumber = 0;

            // a forloop that puts in 100 random numbers
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumber = rnd.Next(0, 1000);
                randomNumbers[i] = randomNumber;
                //Debug Console.WriteLine("number" + i + " " + randomNumbers[i]);
            }

            return randomNumbers;
        }

        static void Bubblesort()
        {
            // local vars
            int[] numbers = new int[10];
            Random rnd = new Random();
            int rndNumber = 0;

            // a forloop that adds random values into the array
            for (int i = 0; i < numbers.Length; i++)
            {
                rndNumber = rnd.Next(0, 100);
                numbers[i] = rndNumber;
            }

            // two forloops one for control the other for indexing
            for (int i = 0; i <= numbers.Length; i++)
            {
                for (int j = 0; j < (numbers.Length-1) - i; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            
            // writes out the numbers in the array added a reverse for opg part c
            foreach (int number in numbers.Reverse())
            {
                Console.WriteLine(number);
            }
        }






    }
}
