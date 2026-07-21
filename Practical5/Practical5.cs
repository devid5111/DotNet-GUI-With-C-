using System;

namespace Practical5
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor overloading
        public Rectangle()
        {
            Width = 1.0;
            Height = 1.0;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Method overloading
        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Console.WriteLine($"Default Rectangle Area: {rect1.CalculateArea()}");

            Rectangle rect2 = new Rectangle(5.0, 10.0);
            Console.WriteLine($"Custom Rectangle Area: {rect2.CalculateArea()}");

            Rectangle rect3 = new Rectangle();
            Console.WriteLine($"Area with passed parameters: {rect3.CalculateArea(7.0, 3.0)}");
        }
    }
}
