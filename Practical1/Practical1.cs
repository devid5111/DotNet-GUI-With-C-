using System;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your City: ");
            string city = Console.ReadLine();

            Console.WriteLine("\n--- User Details ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");
        }
    }
}
