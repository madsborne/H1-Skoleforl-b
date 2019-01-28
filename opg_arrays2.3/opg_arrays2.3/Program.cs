using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_arrays2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating two lists that will contain my boy names and girl names
            // also a string that will take the user input to the switch below
            List<string> boyNames = new List<string>();
            List<string> girlNames = new List<string>();
            string userInput;
            bool keepRunning = true;

            // a infi loop making sure the program keeps running
            while (keepRunning == true)
            {
                // greets the user and let them know their options
                Console.WriteLine("\nto add a name type in add\n");
                Console.WriteLine("to see all the names type all\n");
                Console.WriteLine("to remove a name type remove");
                userInput = Console.ReadLine();

                // my switch that takes a input from the user
                switch (userInput)
                {
                    // lets the user add a name to the list they can select which gender they want to add the name to
                    case "add":
                        Console.Clear();
                        Console.WriteLine("is it a boy or girl name?");
                        string genderInput = Console.ReadLine();
                        if (genderInput == "boy")
                        {
                            Console.WriteLine("Type in the boy name you wanna add");
                            string boyName = Console.ReadLine();
                            boyNames.Add(boyName);
                        }
                        else if (genderInput == "girl")
                        {
                            Console.WriteLine("Type in the girl name you wanna add");
                            string girlName = Console.ReadLine();
                            girlNames.Add(girlName);
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                        break;

                    // let the user see all the names that have been added
                    case "all":
                        Console.Clear();
                        for (int i = 0; i < boyNames.Count; i++)
                        {
                            Console.WriteLine(boyNames[i]);
                        }
                        for (int j = 0; j < girlNames.Count; j++)
                        {
                            Console.WriteLine(girlNames[j]);
                        }
                        break;
                    // let the user remove a name from the list
                    case "remove":
                        Console.Clear();
                        Console.WriteLine("Type in the name you wanna remove");
                        for (int i = 0; i < boyNames.Count; i++)
                        {
                            for (int j = 0; j < girlNames.Count; j++)
                            {
                                Console.WriteLine(boyNames[i]);
                                Console.WriteLine(girlNames[j]);
                                string removeName = Console.ReadLine();

                                if (removeName == boyNames[i])
                                {
                                    boyNames.Remove(boyNames[i]);
                                    Console.WriteLine("name removed");
                                }
                                else if (removeName == girlNames[j])
                                {
                                    girlNames.Remove(girlNames[j]);
                                    Console.WriteLine("name removed");
                                }
                                else
                                {
                                    Console.WriteLine("no name found");
                                }
                            }
                        }


                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("not a vaild input");
                        break;
                }

            }

        }
    }
}
