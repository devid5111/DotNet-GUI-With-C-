namespace PR_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter main string : ");
            string Main_string = Console.ReadLine();

            Console.Write("Enter Sub string : ");
            string Sub_string = Console.ReadLine();

            int len = Sub_string.Length;

            int count = 0;

            int i = 0;

            while (i <= Main_string.Length - len)
            {
                string str = "";

                int k = 0;

                while (k < len)
                {
                    str = str + Main_string[i + k];
                    k++;
                }

                if (str == Sub_string)
                {
                    count++;
                }

                i++;
            }

            Console.WriteLine("Count = " + count);
        }
    }
}