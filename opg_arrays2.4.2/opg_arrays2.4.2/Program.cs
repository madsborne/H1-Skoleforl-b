using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_arrays2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dataTable = new int[4, 250];
            bool keepRunning = true;
            string userInput;

            while (keepRunning == true)
            {
                Console.WriteLine("Hello and welcome you have a few options");
                Console.WriteLine("1: Do you want to add numbers - type add");
                Console.WriteLine("2: Do you want to see all the data in the table? - type all");
                Console.WriteLine("3: Do you want to find a element? - type find");
                Console.WriteLine("4: Do you want see a resume of all the data? - type stats");
                Console.WriteLine("5: Do you wish to exit the program? - type end");
                userInput = Convert.ToString(Console.ReadKey().KeyChar);

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("please type in the number you wish to add");
                        int addNumber = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < dataTable.GetLength(0); i++)
                        {
                            for (int j = 0; j < dataTable.GetLength(250); j++)
                            {
                                dataTable[]
                            }
                        }
                        break;

                    default:
                        break;
                }

            }
        }

    }
}
