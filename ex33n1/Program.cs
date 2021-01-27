using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex33n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give N0");
            string s = Console.ReadLine();
            uint N0 = Convert.ToUInt32(s);

            var sequence = new List<uint>();

            uint N = N0;
            while(true)
            {
                sequence.Add(N);
                if(N==1)
                {
                    break;
                }

                if (N % 2 == 0)
                {
                    N = N / 2;
                } else
                {
                    N = 3 * N + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Sequence with N0={N0} is");
            foreach(var it in sequence)
            {
                Console.Write(it);
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine($"Length of the sequence is {sequence.Count}");
            Console.WriteLine($"Maximum number in the sequence is {sequence.Max()}");
            Console.WriteLine();
        }
    }
}
