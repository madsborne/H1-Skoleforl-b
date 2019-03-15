using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class VendingMachine
    {
        Stack<Product> slots;

        public List<Stack<Product>> vendingSlots = new List<Stack<Product>>();
        public List<Candy> removedCandies = new List<Candy>();
        public List<Drink> removedDrinks = new List<Drink>();

        Candy candy;
        Drink drink;
        Product temp;

        private int moneyBox = 0;
        private int returnMoney = 0;
        private bool buyComplete = false;
        private string returnString = "";

        public VendingMachine()
        {

            FillProduct();
        }

        private int CoinInsert(int userMoney)
        {
            if (userMoney > temp.Price)
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

        private int PickProduct(int id)
        {
            temp = vendingSlots[id].Pop();
            return temp.Price;
        }

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

        private string PushProduct(int productNumber, int userMoney)
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

        private void FillProduct()
        {

            for (int i = 0; i < 6; i++)
            {
                vendingSlots.Add(slots = new Stack<Product>());
            }

            EmptyVending();

            for (int i = 0; i < vendingSlots.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int addingFoamBanana = 0; addingFoamBanana < vendingSlots.Count; addingFoamBanana++)
                        {
                            vendingSlots[0].Push(candy = new Candy("Foam Banana", 5, "xl"));
                        }
                        break;
                    case 1:
                        for (int addingFoamPlatyPus = 0; addingFoamPlatyPus < vendingSlots.Count; addingFoamPlatyPus++)
                        {
                            vendingSlots[1].Push(candy = new Candy("Foam Platypus", 10, "xxl"));
                        }
                        break;
                    case 2:
                        for (int addingFoamDuck = 0; addingFoamDuck < vendingSlots.Count; addingFoamDuck++)
                        {
                            vendingSlots[2].Push(candy = new Candy("Foam Duck", 15, "xl"));
                        }
                        break;
                    case 3:
                        for (int addingCola = 0; addingCola < vendingSlots.Count; addingCola++)
                        {
                            vendingSlots[3].Push(drink = new Drink("Cola", 15, 1));
                        }
                        break;
                    case 4:
                        for (int addingFanta = 0; addingFanta < vendingSlots.Count; addingFanta++)
                        {
                            vendingSlots[4].Push(drink = new Drink("Fanta", 15, 1));
                        }
                        break;
                    case 5:
                        for (int addingFoamDuckDrink = 0; addingFoamDuckDrink < vendingSlots.Count; addingFoamDuckDrink++)
                        {
                            vendingSlots[5].Push(drink = new Drink("Liqid Foam Drink", 20, 0.5));
                        }
                        break;

                    default:
                        break;
                }
            }


        }

        private void EmptyVending()
        {
            for (int i = 0; i < vendingSlots.Count; i++)
            {
                vendingSlots[i].Clear();
            }
        }

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

        private string VendingMenu(char userInput, int productId, int userMoney, string admin)
        {
            if (admin == "adminadminadmin")
            {
                switch (char.ToLower(userInput))
                {
                    case '0':
                        returnString = PushProduct(productId, userMoney);
                        break;

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
                        ChangePrice(productId, userMoney);
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
    }
}
