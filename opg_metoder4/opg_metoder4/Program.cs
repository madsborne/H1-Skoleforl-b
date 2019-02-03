using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_metoder4
{
    // Opdagede først da jeg næsten var færdig med opgaven at der stod arrays håber ikke det gør det store at jeg har kommet til og bruges lists
    class Program
    {
        static void Main(string[] args)
        {
            //asks the user for 7 numbers between 1-20
            Console.WriteLine("Hello i want you to type in 7 random numbers from 1 - 20");
            // Writes out the returned value from Menu();
            Console.WriteLine(Menu());

        }

        /// <summary>
        /// takes in two int lists
        /// </summary>
        /// <param name="userNumbers"></param>
        /// <param name="computerNumbers"></param>
        /// <returns></returns>
        static string LottoLogic(List<int> userNumbers,List<int> computerNumbers)
        {
            // Local Vars
            string winnings = "";
            int totalHits = 0;

            // loops through the two lists and checks how many times the user guessed correctly and if they had a hit totalHits pluses with 1
            for (int i = 0; i < userNumbers.Count; i++)
            {
                for (int j = 0; j < computerNumbers.Count; j++)
                {
                    if (userNumbers[i] == computerNumbers[j])
                    {
                        // debugger Console.WriteLine("you had a hit on " + userNumbers[i]);
                        totalHits++;
                    }
                }
            }
            // checks the totalHit and asigns the correct price
            if (totalHits > 2)
            {
                winnings = "you won 1M";
            }
            else if (totalHits == 0)
            {
                winnings = "you didn't win anything";
            }
            else
            {
                winnings = "you won 100K";
            }

            // returns the winnings
            return winnings;
            
        }

        /// <summary>
        /// Takes in seven user numbers
        /// </summary>
        /// <returns></returns>
        static List<int> UserNumberCollector()
        {
            // creates a int list
            List<int> userNumbers = new List<int>();

            // takes in 7 user numbers and sends returns the list
            for (int userNumberIndex = 0; userNumberIndex < 7; userNumberIndex++)
            {
                // adds the user input into the userNumbers list
                userNumbers.Add(int.Parse(Console.ReadLine()));
            }
            // returns the list of user numbers
            return userNumbers;

        }

        /// <summary>
        /// Seven random computer numbers 
        /// </summary>
        /// <returns></returns>
        static List<int> ComputerNumberCollector()
        {
            List<int> rndComputerNumbers = new List<int>();
            Random rnd = new Random();

            // Generate a number and then adds it to the list
            // resson behind this many is because if dont save the number before moving on it will stay the same through out the program
            // The comments below are just to make it easier for me and you to see what number it is
            
            // Number 1
            int computerNumberOne = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberOne);

            // Number 2
            int computerNumberTwo = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberTwo);

            // Number 3
            int computerNumberThree = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberThree);

            // Number 4
            int computerNumberFour = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberFour);

            // Number 5
            int computerNumberFive = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberFive);

            // Number 6
            int computerNumberSix = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberSix);

            // Number 7
            int computerNumberSeven = rnd.Next(1, 20);
            rndComputerNumbers.Add(computerNumberSeven);

            // returns the list of random numbers
            return rndComputerNumbers;

            /* Debugger
            for (int i = 0; i < rndComputerNumbers.Count; i++)
            {
                Console.WriteLine(rndComputerNumbers[i]);
            }
            */
        }

        /// <summary>
        /// Menu declutter Main takes in 7 numbers and adds them to UserNumberCollector also has the 7 Random numbers from the computer
        /// </summary>
        static string Menu()
        {
            // stores the two arrays that gets returned from the two methods
            List<int> userNumbers = UserNumberCollector();
            List<int> computerNumbers = ComputerNumberCollector();

            // stores the string returned from LottoLogic 
            string winningAmount = LottoLogic(userNumbers, computerNumbers);

            // return the winningAmount back to the user
            return winningAmount;
        }


    }
}
