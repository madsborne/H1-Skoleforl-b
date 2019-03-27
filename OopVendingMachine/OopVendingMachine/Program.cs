using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates the vendingmachine
            VendingMachine vending = new VendingMachine();

            // vars
            bool poweringOn = true;
            bool adminLogin = false;
            string loginPass = "";
            string userInput = "";
            int timer = 0;
            int productID = 0;
            int userMoney = 0;

            // keeps the program running
            while (true)
            {
                // greets the user and asks for a input if the input is adminadminadmin the user is then taken into the admin menu 
                // also prints the products in the machine
                Console.WriteLine("Welcome to this Vending Machine");
                Console.Write(vending.PrintProducts());
                userInput = Console.ReadLine();
                if (userInput == "adminadminadmin")
                {
                    // local vars
                    string localUserInput = "";
                    string localUserMoney = "";

                    // prints the admin menu
                    Console.WriteLine(vending.PrintAdminMenu());
                    ConsoleKeyInfo charUserInput = Console.ReadKey();

                    // try parses the userinput to check if it is a int
                    Int32.TryParse(localUserInput, out productID);
                    
                    // tries to run the vending menu
                    try
                    {
                        Console.WriteLine(vending.VendingMenu(charUserInput.KeyChar, productID, 20, userInput));
                        vending.FillProduct();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                // runes the normal menu
                else
                {
                    Int32.TryParse(userInput, out productID);
                    Console.Clear();
                    Console.WriteLine(vending.PrintOneProduct(productID));
                    Console.WriteLine("Input money!");
                    userInput = Console.ReadLine();
                    Int32.TryParse(userInput, out userMoney);
                    Console.WriteLine(vending.PushProduct(productID, userMoney));
                    Console.ReadKey();
                    Console.Clear(); 
                }
            }
            
        }
    }
}
