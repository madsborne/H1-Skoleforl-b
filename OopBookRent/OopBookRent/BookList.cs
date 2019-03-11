using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBookRent
{
    class BookList
    {
        // creates list that stores the Book obj
        public List<Book> Books = new List<Book>();

        // creates 3 books from the Books from the Book obj + one customer to store the rented books
        Book harryPotter = new Book("Harry Potter", "J.K");
        Book powerOfCode = new Book("The Power of Coding", "Some random guy from the internet");
        Book learningFromYoutube = new Book("Learn everything from Youtube", "Youtube");
        Customer customer = new Customer();

        // adds the 3 books to the Books list
        public BookList()
        {
            Books.Add(harryPotter);
            Books.Add(powerOfCode);
            Books.Add(learningFromYoutube);
        }

        // Switch case that controls the menu 
        public void BookControl(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    BookDisplay();
                    break;
                case "2":
                    Console.WriteLine("type in the number infront of the book");
                    RentBook();
                    break;
                case "3":
                    RentedBook();
                    break;
                case "4":
                    ReturnBook();
                    break;

                default:
                    Console.WriteLine("Wrong input try again");
                    break;
            }
        }

        // displays the books from the book list 
        public void BookDisplay()
        {
            // run through the Books list
            int counter = 1;
            foreach (Book book in Books)
            {
                Console.WriteLine($"{counter} " + book.BookInfo());
                counter++;
            }
        }

        // let the user rent a book and then put it in a stack in the Customer class
        public void RentBook()
        {
            int counter = 0;
            foreach (Book book in Books)
            {
                Console.WriteLine($"{counter} - " + book.BookInfo());
                counter++;
            }
            // takes in user input and then parses it and then uses that number to identifiy what book the user wants to rent
            string bookId = Console.ReadLine();
            customer.CustomerBooks.Push(Books[Int32.Parse(bookId)]);
            Books.RemoveAt(Int32.Parse(bookId));
        }

        // displays the rented books 
        public void RentedBook()
        {
            foreach (Book book in customer.CustomerBooks)
            {
                Console.WriteLine(book.Name);
            }
        }

        // returns the book back to the books list
        public void ReturnBook()
        {
            if (customer.CustomerBooks.Count == 0)
            {
                Console.WriteLine("No more books to return");
            }
            else
            {
                Console.WriteLine("Returned - " + customer.CustomerBooks.Peek().Name);
                Books.Add(customer.CustomerBooks.Pop());
            }

        }
    }
}
