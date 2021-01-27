using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex31stapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tbl = File.ReadAllLines("../../Program.cs");

            foreach(var it in tbl)
            {
                Console.WriteLine(it);
            }
        }
    }
}
