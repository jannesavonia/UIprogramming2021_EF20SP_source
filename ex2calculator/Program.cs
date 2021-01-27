using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 1st number");
            String l = Console.ReadLine();
            Console.WriteLine("Give 2nd number");
            String r = Console.ReadLine();
            Console.WriteLine("Give operator");
            String op = Console.ReadLine();

            int left = Convert.ToInt32(l);
            int right = Convert.ToInt32(r);

            if (op=="+")
            {
                Console.WriteLine($"{left} + {right} = {left + right}.");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{left} + {right} = {left - right}.");
            }
        }
    }
}
