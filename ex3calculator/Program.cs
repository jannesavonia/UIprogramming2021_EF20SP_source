using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give an expression");
            String exp = Console.ReadLine();

            var strlist = exp.Split();

            int left = Convert.ToInt32(strlist[0]);
            int right = Convert.ToInt32(strlist[2]);
            string op = strlist[1];

            if (op == "+")
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

