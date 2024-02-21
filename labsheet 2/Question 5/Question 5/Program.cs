using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    using System;
    using System.Collections.Generic;

    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine("Book '" + Title + "' by " + Author + " has been borrowed.");
            }
            else
            {
                Console.WriteLine("Sorry, the book '" + Title + "' by " + Author + " is not available.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate multiple book objects
            List<LibraryBook> books = new List<LibraryBook>
        {
            new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", true),
            new LibraryBook("To Kill a Mockingbird", "Harper Lee", false),
            new LibraryBook("1984", "George Orwell", true)
        };

            // Perform book borrowing
            Console.WriteLine("Library Status Before Borrowing:");
            DisplayLibraryStatus(books);

            Console.WriteLine("\nBorrowing a book...");
            books[0].BorrowBook();

            Console.WriteLine("\nLibrary Status After Borrowing:");
            DisplayLibraryStatus(books);

            Console.ReadLine(); // Keep the console window open
        }

        static void DisplayLibraryStatus(List<LibraryBook> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("Title: " + book.Title + ", Author: " + book.Author + ", Available: " + book.Available);
            }
        }
    }

}