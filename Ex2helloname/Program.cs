using System;

namespace Ex2helloname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your name");
            String name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");
        }
    }
}
