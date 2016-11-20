using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string name = "Chris";
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"The current time is {DateTime.Now}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

            
        }
    }
}
