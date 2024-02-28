using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);

            Console.WriteLine($"The area of the rectangle is: {area}");
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;

        }
    }
}
