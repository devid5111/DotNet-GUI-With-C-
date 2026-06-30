namespace PR_04
{

    class Person
    {
        string Name;
        int Age;

        public void ShowDetails(string name , int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Name : {Name} ");
            Console.WriteLine($"Age : {Age} ");
        }


    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Enter you name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Person a1;

            a1 = new Person();
            a1.ShowDetails(name, age);

        }
    }
}
