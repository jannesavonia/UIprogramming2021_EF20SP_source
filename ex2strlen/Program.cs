using System;

namespace ex2strlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the 1st string");
            String s1 = Console.ReadLine();
            Console.WriteLine("Give the 2nd string");
            String s2 = Console.ReadLine();

            if (s1.Length> s2.Length)
            {
                Console.WriteLine(s1 + " is longer");
            }
            else if(s1.Length < s2.Length)
            {
                Console.WriteLine(s2 + " is longer");
            } else
            {
                Console.WriteLine(s1 + " and " + s2 + " has same length");
            }
        }
    }
}
