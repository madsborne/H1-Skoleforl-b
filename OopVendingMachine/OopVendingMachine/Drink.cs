using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class Drink : Product
    {
        private double liter;

        public double Liter
        {
            get
            {
                return liter;
            }
            set
            {
                liter = value;
            }
        }

        public Drink(string drinkName, int drinkPrice, double drinkLiter)
        {
            Name = drinkName;
            Price = drinkPrice;
            Liter = drinkLiter;
            Id = 1;
        }

    }
}
