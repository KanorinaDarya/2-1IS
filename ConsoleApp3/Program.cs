using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("myhello");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();
        }
    }
}
