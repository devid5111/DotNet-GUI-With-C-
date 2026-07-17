using System;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 999: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number <= 999)
            {
                Console.WriteLine(NumberToWords(number));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 999.");
            }
        }

        static string NumberToWords(int number)
        {
            if (number == 0) return "Zero";

            string[] unitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string words = "";

            if ((number / 100) > 0)
            {
                words += unitsMap[number / 100] + " Hundred";
                number %= 100;
                if (number > 0)
                {
                    words += " and ";
                }
            }

            if (number > 0)
            {
                if (number < 20)
                {
                    words += unitsMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + unitsMap[number % 10];
                    }
                }
            }

            return words;
        }
    }
}
