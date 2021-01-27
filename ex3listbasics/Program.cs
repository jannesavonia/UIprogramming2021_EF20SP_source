using System;
using System.Collections.Generic;

namespace ex3listbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;

            var strings = new List<string>();
            for(int i=0; i<10; i++)
            {
                Console.WriteLine($"Give string {i + 1}/{N}");
                var s = Console.ReadLine();
                strings.Add(s);
            }

            strings.Sort();

            foreach(var it in strings)
            {
                Console.WriteLine(it);
            }
        }
    }
}
