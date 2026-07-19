using System;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the substring: ");
            string subString = Console.ReadLine();

            int count = 0;
            int i = 0;

            if (!string.IsNullOrEmpty(subString) && !string.IsNullOrEmpty(mainString))
            {
                while ((i = mainString.IndexOf(subString, i, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    i += subString.Length;
                    count++;
                }
            }

            Console.WriteLine($"The substring occurs {count} times within the main string.");
        }
    }
}
