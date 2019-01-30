using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_metoder1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a loop that keep the program running
            while (true)
            {
                // greets the user to let the user know what their options are
                Console.WriteLine("Welcome user select on the following use that function of the program");
                Console.WriteLine("1: Adding, Dividing, The Power of the number, Moduls");
                Console.WriteLine("2: Pythagoras");
                Console.WriteLine("3: Age checker");
                Console.WriteLine("Type 1 or 2 or 3 to select");

                // menu method
                GuiApplicationRunner();
            }
        }

        /// <summary>
        /// Takes in two ints and does all sort of magic on the two numbers and then displays the results
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        static void MathLogic(int numberOne, int numberTwo)
        {
            // local vars
            int userNumberOne = numberOne;
            int userNumberTwo = numberTwo;
            int userNumbersPlus;
            int userNumberDivide;
            int userNumberModu;
            double userNumberPower;

            // Math Logic
            userNumbersPlus = userNumberOne + userNumberTwo;
            userNumberDivide = userNumberOne / userNumberTwo;
            userNumberModu = userNumberOne % userNumberTwo;
            userNumberPower = Math.Pow(userNumberOne, userNumberTwo);

            // Debug / testing / GUI Part of the method
            Console.Clear();
            Console.WriteLine("The two numbers added " + userNumbersPlus);
            Console.WriteLine("The two numbers diviede " + userNumberDivide);
            Console.WriteLine("The modu of the two numbers " + userNumberModu);
            Console.WriteLine("The power of the first number " + userNumberPower + "\n");

        }

        /// <summary>
        /// This Method Connects all the Methods
        /// </summary>
        static void GuiApplicationRunner()
        {
            // Local vars
            string userInput = Console.ReadLine();

            // a switch that controls the menu for the program from the typed in input it finds out where you wanna go
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("\ntype in two numbers");
                    MathLogic(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;

                case "2":
                    Console.WriteLine("\ntype in two numbers");
                    PowerLogic(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;

                case "3":
                    Console.WriteLine("\ntype in your name and age");
                    AgeChecker(Console.ReadLine(), int.Parse(Console.ReadLine()));
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }

        /// <summary>
        /// Takes in two ints and does the Pythagoras calculation
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        static void PowerLogic(int numberOne, int numberTwo)
        {
            // Local vars
            int userNumberOne = numberOne;
            int userNumberTwo = numberTwo;
            double userNumberOnePowered;
            double userNumberTwoPowered;
            double userResult;

            // Logic
            userNumberOnePowered = Math.Pow(userNumberOne, userNumberOne);
            userNumberTwoPowered = Math.Pow(userNumberTwo, userNumberTwo);
            userResult = Math.Pow(userNumberOne,userNumberOne) + Math.Pow(userNumberTwo,userNumberTwo);

            // checks what number from the put that have been powered is bigger
            if (userNumberOnePowered > userNumberTwoPowered)
            {
                Console.WriteLine("The first number is bigger \n");
            }
            else if (userNumberOnePowered < userNumberTwoPowered)
            {
                Console.WriteLine("The second number is bigger \n");
            }
            else
            {
                Console.WriteLine("They are equal \n");
            }

            // Gui
            Console.WriteLine("The result is " + userResult + "\n");
        }

        /// <summary>
        /// takes in a string and a int and then checks from the input you give it what you are allowed to do
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void AgeChecker(string name, int age)
        {
            // Age checker logic that looks at the age typed in to see what you are allowed to do
            if (age < 3)
            {
                Console.WriteLine("\n" + name + " You are allowed to wear diaper" + "\n");
            }
            else if (age >= 3 && age < 16)
            {
                Console.WriteLine("\n" + name + " You are allowed to do absolutly nothing" + "\n");
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine("\n" + name + " Party time you are allowed to drink!" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + name + " oh wow you're all grown up you are allowed to do it all!" + "\n");
            }
        }
    }
}
