using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class Product
    {
        private string name;
        private int price;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Product()
        {

        }
    }
}
