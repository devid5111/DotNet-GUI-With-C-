using System;

namespace PR_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number between 0 to 999 : ");
            int no = int.Parse(Console.ReadLine());

            int temp = no;

            string Result1 = "";
            string Result2 = "";
            string Result3 = "";

            if (no < 0 || no > 999)
            {
                Console.WriteLine("Please Enter Valid Number Between 0 to 999");
                return;
            }
            else if (no >= 0 && no <= 9)
            {
                Result1 = First(no);
            }
            else if (no >= 10 && no <= 19)
            {
                Result1 = Fourth(no);
            }
            else if (no >= 20 && no <= 99)
            {
                int j = 1;

                while (no != 0)
                {
                    int x = no % 10;

                    if (j == 1)
                    {
                        if (x != 0)
                        {
                            Result2 = "-" + First(x);
                        }
                    }
                    else
                    {
                        Result1 = Second(x);
                    }

                    j++;
                    no /= 10;
                }
            }
            else
            {
                int hundred = no / 100;
                int lastTwo = no % 100;

                Result1 = Third(hundred);

                if (lastTwo >= 10 && lastTwo <= 19)
                {
                    Result2 = " " + Fourth(lastTwo);
                }
                else
                {
                    int tens = lastTwo / 10;
                    int units = lastTwo % 10;

                    if (tens != 0)
                    {
                        Result2 = " " + Second(tens);
                    }

                    if (units != 0)
                    {
                        if (tens != 0)
                            Result3 = "-" + First(units);
                        else
                            Result3 = " " + First(units);
                    }
                }
            }

            Num_word(temp, Result1, Result2, Result3);
        }

        public static string Fourth(int no)
        {
            switch (no)
            {
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: return "";
            }
        }

        public static string Third(int no)
        {
            switch (no)
            {
                case 1: return "One Hundred";
                case 2: return "Two Hundred";
                case 3: return "Three Hundred";
                case 4: return "Four Hundred";
                case 5: return "Five Hundred";
                case 6: return "Six Hundred";
                case 7: return "Seven Hundred";
                case 8: return "Eight Hundred";
                case 9: return "Nine Hundred";
                default: return "";
            }
        }

        public static string Second(int no)
        {
            switch (no)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
                default: return "";
            }
        }

        public static string First(int no)
        {
            switch (no)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "";
            }
        }

        public static void Num_word(int no, string r1, string r2, string r3)
        {
            string final_word = (r1 + r2 + r3).Trim();
            Console.WriteLine($"Your Number {no} in Word = {final_word}");
        }
    }
}