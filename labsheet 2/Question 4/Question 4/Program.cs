using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    using System;

    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Parameterized constructor
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects using the constructor
            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Smartphone", 499.99);

            // Display product details
            Console.WriteLine("Product 1:");
            Console.WriteLine("Name: " + product1.ProductName);
            Console.WriteLine("Price: $" + product1.Price);

            Console.WriteLine();

            Console.WriteLine("Product 2:");
            Console.WriteLine("Name: " + product2.ProductName);
            Console.WriteLine("Price: $" + product2.Price);

            Console.ReadLine(); // Keep the console window open
        }
    }

}