using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBookRent
{
    class Customer
    {
        // can be advanced later on i didnt need to put in a class for it self when it's only a single user
        // creates a customer to store the books the user rents
        public Stack<Book> CustomerBooks = new Stack<Book>();
    }
}
