using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string");
            String s = Console.ReadLine();

            if(s.Contains("cat")) 
            {
                Console.WriteLine("String contained 'cat'.");
            } else
            {
                Console.WriteLine("String did not contain 'cat'.");
            }
        }
    }
}
