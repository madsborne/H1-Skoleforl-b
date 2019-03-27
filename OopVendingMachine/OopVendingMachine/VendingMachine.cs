using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class VendingMachine
    {
        // stacks and lists
        private Stack<Product> slots;
        private List<Stack<Product>> vendingSlots = new List<Stack<Product>>();
        private List<Candy> removedCandies = new List<Candy>();
        private List<Drink> removedDrinks = new List<Drink>();

        // uninstanced objects
        private Candy candy;
        private Drink drink;
        private Product temp;

        // atti
        private int moneyBox = 0;
        private int returnMoney = 0;
        private bool buyComplete = false;
        private string returnString = "";

        /// <summary>
        /// when created it fills the vendingmachine because of the FillProduct(); method
        /// </summary>
        public VendingMachine()
        {
            for (int i = 0; i < 6; i++)
            {
                vendingSlots.Add(slots = new Stack<Product>());
            }

            FillProduct();
        }

        /// <summary>
        /// takes in userMoney if usermoney is greater then price it returns the rest and turns to buycomplete to true
        /// </summary>
        /// <param name="userMoney"></param>
        /// <returns></returns>
        private int CoinInsert(int userMoney)
        {
            if (userMoney >= temp.Price)
            {
                returnMoney = userMoney -= temp.Price;
                moneyBox += temp.Price;
                buyComplete = true;
                return returnMoney;
            }
            else
            {
                buyComplete = false;
                return userMoney;
            }
            
        }

        /// <summary>
        /// lets the user pick a product from the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int PickProduct(int id)
        {
            temp = vendingSlots[id].Pop();
            return temp.Price;
        }

        /// <summary>
        /// checks the vendingmachines stash to see if it full or not 
        /// </summary>
        /// <returns></returns>
        private bool CountCheck()
        {
            int productCount = 0;

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                for (int j = 0; j < vendingSlots[i].Count; j++)
                {
                    productCount++;
                }
            }
            if (productCount < 30)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// if the buy was complete in CoinInsert this method runs and pushes the product to the user
        /// </summary>
        /// <param name="productNumber"></param>
        /// <param name="userMoney"></param>
        /// <returns></returns>
        public string PushProduct(int productNumber, int userMoney)
        {
            PickProduct(productNumber);
            CoinInsert(userMoney);

            if (buyComplete == true)
            {
                switch (temp.Id)
                {
                    case 0:
                        removedCandies.Add((Candy)temp);
                        break;
                    case 1:
                        removedDrinks.Add((Drink)temp);
                        break;

                    default:
                        break;
                }
                return $"You bought {temp.Name}.\n" +
                    $"Money returned {returnMoney}";
            }
            else
            {
                return "You didn't have enough money please try again.";
            }

        }

        /// <summary>
        /// first empties the machine and restock it
        /// </summary>
        public void FillProduct()
        {
            
            EmptyVending();

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int addingFoamBanana = 0; addingFoamBanana < 5; addingFoamBanana++)
                        {
                            vendingSlots[0].Push(candy = new Candy("Foam Banana", 5, "xl"));
                        }
                        break;
                    case 1:
                        for (int addingFoamPlatyPus = 0; addingFoamPlatyPus < 5; addingFoamPlatyPus++)
                        {
                            vendingSlots[1].Push(candy = new Candy("Foam Platypus", 10, "xxl"));
                        }
                        break;
                    case 2:
                        for (int addingFoamDuck = 0; addingFoamDuck < 5; addingFoamDuck++)
                        {
                            vendingSlots[2].Push(candy = new Candy("Foam Duck", 15, "xl"));
                        }
                        break;
                    case 3:
                        for (int addingCola = 0; addingCola < 5; addingCola++)
                        {
                            vendingSlots[3].Push(drink = new Drink("Cola", 15, 1));
                        }
                        break;
                    case 4:
                        for (int addingFanta = 0; addingFanta < 5; addingFanta++)
                        {
                            vendingSlots[4].Push(drink = new Drink("Fanta", 15, 1));
                        }
                        break;
                    case 5:
                        for (int addingFoamDuckDrink = 0; addingFoamDuckDrink < 5; addingFoamDuckDrink++)
                        {
                            vendingSlots[5].Push(drink = new Drink("Liqid Foam Drink", 20, 0.5));
                        }
                        break;

                    default:
                        break;
                }
            }


        }

        /// <summary>
        /// Empties the machine
        /// </summary>
        private void EmptyVending()
        {
            for (int i = 0; i < vendingSlots.Count; i++)
            {
                vendingSlots[i].Clear();
            }
            
        }

        /// <summary>
        /// changes the price and lets the user know what item and the price it has been changed to
        /// </summary>
        /// <param name="product"></param>
        /// <param name="newPrice"></param>
        /// <returns></returns>
        private string ChangePrice(int product, int newPrice)
        {
            string tempName = "";

            foreach (Product item in vendingSlots[product])
            {
                item.Price = newPrice;
                tempName = item.Name;
            }
            
            return $"The price of {tempName} has been changed to {newPrice}";

        }
        
        /// <summary>
        /// admin menu lets the admin refill the machine empty it and change price
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="productId"></param>
        /// <param name="userMoney"></param>
        /// <param name="admin"></param>
        /// <returns></returns>
        public string VendingMenu(char userInput, int productId, int userMoney, string admin)
        {
            if (admin == "adminadminadmin")
            {
                switch (char.ToLower(userInput))
                {
                    
                    case 'x':
                        if (CountCheck() == false)
                        {
                            FillProduct();
                            returnString = "Filled up";
                        }
                        else
                        {
                            returnString = "Already full";
                        }

                        break;

                    case 'z':
                        EmptyVending();
                        returnString = "Machine has been emptyed";
                        break;

                    case 'c':
                        returnString = ChangePrice(productId, userMoney);
                        break;

                    case 'p':
                        returnString = PrintProducts();
                        break;

                    default:
                        break;
                }
            }

            else
            {
               returnString = PushProduct(productId, userMoney);
            }

            return returnString;
        }

        /// <summary>
        /// prints the products in the machine
        /// </summary>
        /// <returns></returns>
        public string PrintProducts()
        {
            returnString = "";

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                returnString += $"\nID - {i} \n" +
                    $"Name  - {vendingSlots[i].Peek().Name}\n" +
                    $"Price - {vendingSlots[i].Peek().Price}\n"; 
            }

            return returnString + "\nInput ID : ";
        }

        /// <summary>
        /// only prints one product
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public string PrintOneProduct(int productID)
        {
            returnString = $"Name = {vendingSlots[productID].Peek().Name}.\n" +
                           $"Price = {vendingSlots[productID].Peek().Price}.";
            return returnString;
        }

        /// <summary>
        /// prints the admin menu
        /// </summary>
        /// <returns></returns>
        public string PrintAdminMenu()
        {

            return "Admin Menu  \n" +
                   "Press [X] to fill vending machine.\n" +
                   "Press [Z] to empty machine.\n" +
                   "Press [C] to change price.\n" +
                   "Press [P] to print products.\n";
        }
    }
}
