using System;
using System.Collections.Generic;

namespace ex3partial
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = new List<string>();

            Console.WriteLine("Give strings, terminate by END");
            while (true)
            {
                string s = Console.ReadLine();
                if(s=="END")
                {
                    break;
                }
                stringList.Add(s);
            }

            Console.WriteLine();

            //Print 1st, 3rd, 5th...
            for (int i = 0; i < stringList.Count; i += 2)
            {
                Console.WriteLine(stringList[i]);
            }

            Console.WriteLine();

            //Print in reverse order
            for (int i = stringList.Count-1; i >=0; i--)
            {
                Console.WriteLine(stringList[i]);
            }
        }
    }
}
