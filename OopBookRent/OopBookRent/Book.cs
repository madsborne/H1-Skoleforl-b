using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBookRent
{
    class Book
    {
        // private vars
        private string name;
        private string author;

        // public props
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
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        // asigns value to the private vars
        public Book(string bookName, string bookAuthor)
        {
            Name = bookName;
            Author = bookAuthor;
        }

        // a method that displays the book info to easily see the full info of the book 
        public string BookInfo()
        {
           string bookInfo = $"Book Name - {Name}\n" +
                             $"Book Author - {Author}\n";

            return bookInfo;
        }
    }
}
