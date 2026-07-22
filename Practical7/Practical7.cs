using System;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("\n--- String Manipulations ---");
            
            // Substring
            if (input.Length >= 3)
            {
                Console.WriteLine($"Substring (first 3 chars): {input.Substring(0, 3)}");
            }
            else
            {
                Console.WriteLine($"Substring: {input} (length < 3)");
            }

            // Replace
            string replaced = input.Replace('a', '*').Replace('A', '*');
            Console.WriteLine($"Replace 'a' or 'A' with '*': {replaced}");

            // ToUpper
            Console.WriteLine($"ToUpper: {input.ToUpper()}");

            // ToLower
            Console.WriteLine($"ToLower: {input.ToLower()}");

            // Split
            Console.WriteLine("Split by space:");
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine($"- {word}");
            }
        }
    }
}
