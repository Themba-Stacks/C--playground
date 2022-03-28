// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            SayHello(name);
            Console.WriteLine($"{Environment.NewLine} on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }

        static void SayHello(String name) => Console.WriteLine($"Hello {name}");
    }
}
