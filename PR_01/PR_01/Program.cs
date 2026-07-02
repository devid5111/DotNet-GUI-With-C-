namespace PR_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter City :");
            string city = Console.ReadLine();


            Console.WriteLine($"Roll number : {roll}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"City : {city}");
            Console.WriteLine($"Age : {age}");

            Console.WriteLine();

        }
    }
}
