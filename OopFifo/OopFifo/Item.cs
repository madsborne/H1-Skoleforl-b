using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFifo
{
    class Item
    {
        // private vars
        private string itemName;
        private int price;
        private string description;
        private string seller;

        // public props
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
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
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string Seller
        {
            get
            {
                return seller;
            }
            set
            {
                seller = value;
            }
        }

        // con that takes in the user input and then asign it to the public props
        public Item(string uItemName, int uPrice, string uDescription, string uSeller)
        {
            ItemName = uItemName;
            Price = uPrice;
            Description = uDescription;
            Seller = uSeller;
        }
    }
}
