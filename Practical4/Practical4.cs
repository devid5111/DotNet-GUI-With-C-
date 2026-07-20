using System;

namespace Practical4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Alice", Age = 20 };
            Person p2 = new Person { Name = "Bob", Age = 22 };

            Console.WriteLine("Person Details:");
            p1.ShowDetails();
            p2.ShowDetails();
        }
    }
}
