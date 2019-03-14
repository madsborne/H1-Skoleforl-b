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

        public VendingMachine()
        {
            
            FillProduct();
        }

        public int CoinInsert(int userMoney, int vendingPrice)
        {
            return 0;
        }

        public int PickProduct(int id)
        {
            return 0;
        }

        private void CountCheck()
        {

        }

        //public Product ReturnProduct()
        //{
            
        //}

        public void FillProduct()
        {
            for (int i = 0; i < 6; i++)
            {
                vendingSlots.Add(slots = new Stack<Product>());
            }

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
    }
}
