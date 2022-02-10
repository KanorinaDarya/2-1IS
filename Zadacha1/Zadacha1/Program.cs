using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Введите Ваше имя. ");
            name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");
            Console.ReadKey();
        }
    }
}
