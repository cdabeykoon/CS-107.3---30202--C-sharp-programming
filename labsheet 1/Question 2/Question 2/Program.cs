using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number #{i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{number} is {(number % 2 == 0 ? "even" : "odd")}");
            }

        }
    }
}
