using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFifo
{
    class LogicController
    {
        // creates the queue
        public Queue<Item> queueItems = new Queue<Item>();
        
        // creates a new item obj with the typed in info from the user
        public void AddItem(string userItemName, int userPrice, string userDescription, string userSeller)
        {
            Item newItem = new Item(userItemName, userPrice, userDescription, userSeller);
            queueItems.Enqueue(newItem);
        }

        // deletes a item
        public void DeleteItem()
        {
            queueItems.Dequeue();
        }

        // Finds a item in the queue
        public string FindItem(int userInput)
        {
            return $"{queueItems.ElementAt(userInput).ItemName} - Sold by -> {queueItems.ElementAt(userInput).Seller}";
        }

        // Finds the first and last item in the queue 
        public string FindMinMaxItems()
        {
            if (queueItems.Count == 0)
            {
                return "No items in queue";
            }
            else
            {
                return $"Min -> {queueItems.First().ItemName} - Max -> {queueItems.Last().ItemName}";
            }
        }
    }
}
