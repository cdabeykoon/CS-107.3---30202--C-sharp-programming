using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms (N) for Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
