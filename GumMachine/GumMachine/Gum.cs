using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class Gum
    {
        private string flavor;
        public string Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
        public string[] flavors = new string[] {"blueberry","blackberry","tuttifrutti","orange","strawberry","apple"};
        public Gum(int id)
        {
            Flavor = flavors[id];
            
        }
    }
}
