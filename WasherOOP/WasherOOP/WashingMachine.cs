using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherOOP
{
    class WashingMachine
    {
        // a public method that runs the programs menu
        public void Menu(string userInput)
        {
            // controls the users input
            switch (userInput.ToLower())
            {
                case "1":
                    Console.WriteLine("have you closed the door?");
                    Start("eco", Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("have to closed the door?");
                    Start("normal", Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("not a valid mode");
                    break;
            }
        }

        /// <summary>
        /// a method that starts the program depending on the user input
        /// </summary>
        /// <param name="userInputWashMode"></param>
        /// <param name="userDoorStatus"></param>
        public void Start(string userInputWashMode, string userDoorStatus)
        {
            if (userDoorStatus.ToLower() == "yes" && userInputWashMode == "eco")
            {
                Console.WriteLine("Running eco mode");
            }
            else if (userDoorStatus.ToLower() == "yes" && userInputWashMode == "normal")
            {
                Console.WriteLine("Running normal mode");
            }
            else
            {
                Console.WriteLine("you need to close the door first");
            }
        }


    }
}
