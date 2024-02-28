using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    public class Shape
    {
        // Fields
        protected string shapeType;
        protected double area;

        // Constructor
        public Shape(string shapeType)
        {
            this.shapeType = shapeType;
        }

        // Method to calculate area (to be overridden by subclasses)
        public virtual void CalculateArea(double val1, double val2 = 0)
        {
            // To be implemented by subclasses
        }

        // Method to display shape information
        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {shapeType}");
            Console.WriteLine($"Area: {area}");
        }
    }

    public class Rectangle : Shape
    {
        // Fields
        private double length;
        private double width;

        // Constructor
        public Rectangle() : base("Rectangle")
        {
        }

        // Method to set dimensions of rectangle
        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea(length, width);
        }

        // Override CalculateArea method for rectangle
        public override void CalculateArea(double val1, double val2 = 0)
        {
            area = val1 * val2;
        }
    }

    public class Circle : Shape
    {
        // Fields
        private double radius;

        // Constructor
        public Circle() : base("Circle")
        {
        }

        // Method to set radius of circle
        public void SetRadius(double radius)
        {
            this.radius = radius;
            CalculateArea(radius);
        }

        // Override CalculateArea method for circle
        public override void CalculateArea(double val1, double val2 = 0)
        {
            area = Math.PI * val1 * val1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5, 3);
            // Display shape information for the rectangle
            rectangle.DisplayShapeInfo();

            Console.WriteLine();

            // Create an instance of Circle
            Circle circle = new Circle();
            circle.SetRadius(4);
            // Display shape information for the circle
            circle.DisplayShapeInfo();
        }
    }
}
