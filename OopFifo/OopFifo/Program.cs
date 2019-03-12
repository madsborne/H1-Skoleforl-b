using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFifo
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicController logic = new LogicController();
            bool keepProgramRunning = true;
            while (keepProgramRunning)
            {
                Console.Clear();
                Console.WriteLine("1: Add Item");
                Console.WriteLine("2: Delete Item");
                Console.WriteLine("3: Show item count");
                Console.WriteLine("4: Show first to last item in queue");
                Console.WriteLine("5: Find item if you know it's number");
                Console.WriteLine("6: Print Items");
                Console.WriteLine("7: Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    // add item
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Name of the item");
                        string userInputItemName = Console.ReadLine();

                        Console.WriteLine("Price of the item");
                        int userInputPrice = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Description of the item");
                        string userInputDescription = Console.ReadLine();

                        Console.WriteLine("The name of the seller");
                        string userInputSeller = Console.ReadLine();
                        
                        // sends all the typed in info to AddItem Method in logic
                        logic.AddItem(userInputItemName, userInputPrice, userInputDescription, userInputSeller);
                        break;

                    // Delete item
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"You deleted - {logic.queueItems.Peek().ItemName}");
                        Console.WriteLine($"Sold by - {logic.queueItems.Peek().Seller}");
                        logic.DeleteItem();
                        Console.ReadKey();
                        break;

                   // Show number of items
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"There are this many items - {logic.queueItems.Count}");
                        Console.ReadKey();
                        break;
                   
                   // Shows the first and last item in the Queue
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Min to Max Items in the Queue");
                        Console.WriteLine(logic.FindMinMaxItems());
                        Console.ReadKey();
                        break;

                   // Finds a item by a number
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Type in the item number");
                        string findItemName = logic.FindItem(int.Parse(Console.ReadLine()));
                        Console.WriteLine(findItemName);
                        Console.ReadKey();
                        break;

                   // Print Items
                    case "6":
                        Console.Clear();
                        int counter = 0;
                        foreach (Item queuedItem in logic.queueItems)
                        {
                            Console.WriteLine($"{counter}: Item - {queuedItem.ItemName}\n" +
                                $"   Price - {queuedItem.Price}\n" +
                                $"   Description - {queuedItem.Description}\n" +
                                $"   Name of the seller - {queuedItem.Seller}\n");
                            counter++;
                        }
                        Console.ReadKey();
                        break;
                   // keeps the loop running
                    case "7":
                        keepProgramRunning = false;
                        break;
                  // tells the user they typed wrong
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
