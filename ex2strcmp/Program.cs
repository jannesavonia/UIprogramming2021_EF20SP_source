using System;

namespace ex2strcmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the 1st string");
            String s1 = Console.ReadLine();
            Console.WriteLine("Give the 2nd string");
            String s2 = Console.ReadLine();

            if(String.Compare(s1, s2)<0)
            {
                Console.WriteLine(s1 + " is first");
            } else
            {
                Console.WriteLine(s2 + " is first");
            }
        }
    }
}
