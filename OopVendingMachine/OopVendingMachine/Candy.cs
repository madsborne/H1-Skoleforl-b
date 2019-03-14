using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopVendingMachine
{
    class Candy : Product
    {
        private string size;

        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public Candy(string candyName, int candyPrice, string candySize)
        {
            Name = candyName;
            Price = candyPrice;
            Size = candySize;
            Id = 0;
        }

    }
}
