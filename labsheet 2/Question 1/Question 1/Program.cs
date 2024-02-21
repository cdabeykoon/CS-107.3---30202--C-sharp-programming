using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    using System;

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of the Book class
            Book myBook = new Book();

            // Set values for the properties
            myBook.Title = "Madol Duwa";
            myBook.Author = "Martin Wikramasingha";

            // Display the information on the console
            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadLine(); // Keep the console window open
        }
    }

}
