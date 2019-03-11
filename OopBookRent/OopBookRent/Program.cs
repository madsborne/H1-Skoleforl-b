using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBookRent
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a new booklist obj 
            BookList bookList = new BookList();
            // keeps the program running
            while (true)
            {
                // shows the user all the choices they have 
                Console.WriteLine("1: See books");
                Console.WriteLine("2: Rent book");
                Console.WriteLine("3: See rented books");
                Console.WriteLine("4: Return book");
                bookList.BookControl(Console.ReadLine()); 
            }

        }
    }
}
