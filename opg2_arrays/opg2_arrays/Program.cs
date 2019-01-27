using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg2_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string[] userNames = new string[10];

            string userPassWord;
            string[] userPassWords = new string[10];

            string userInput;
            string userLoginName;
            string userLoginPassword;

            int loginTries = 0;

            userNames[1] = "lasse";
            userNames[2] = "ole";
            userNames[3] = "per";
            userNames[4] = "bo";

            userPassWords[1] = "lasse";
            userPassWords[2] = "ole";
            userPassWords[3] = "per";
            userPassWords[4] = "bo";

            Console.WriteLine("Welcome i want you to type in your username");
            Console.WriteLine("if you want to create a new user type create");

            userInput = Console.ReadLine().ToLower();

            if (userInput == "create")
            {
                Console.WriteLine("type in the username you want to have");
                userName = Console.ReadLine().ToLower();

                Console.WriteLine("Now type in a password");
                userPassWord = Console.ReadLine().ToLower();

                Console.WriteLine("your username is " + userName + "\nyour password is " + userPassWord);

                userNames[0] = userName;
                userPassWords[0] = userPassWord;

                Console.WriteLine("Please type in your username");
                userInput = Console.ReadLine();


            }

            foreach (string arrayUserName in userNames)
            {
                if (arrayUserName == userInput)
                {

                    Console.WriteLine("Please type in your password");
                    userLoginPassword = Console.ReadLine();

                    foreach (string arrayPassWord in userPassWords)
                    {
                        if (arrayPassWord == userLoginPassword)
                        {
                            Console.WriteLine("You are now logged in");
                        }

                    }

                }

            }
        }
    }
}
