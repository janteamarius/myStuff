namespace MyStuffApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { FirstName = "Andrei", LastName = "Andrei" };
            System.Console.WriteLine("Hello world from home location!");
            System.Console.WriteLine($"{p1.LastName} {p1.FirstName}");
        }
    }
}
