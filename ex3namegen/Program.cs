using System;
using System.Collections.Generic;

namespace ex3namegen
{
    class Program
    {
        static List<string> ReadList(string listName)
        {
            Console.WriteLine($"Give {listName}, terminate by empty string.");
            var tmpList = new List<string>();
            
            while(true)
            {
                string s = Console.ReadLine();
                if(s=="")
                {
                    return tmpList;
                }
                tmpList.Add(s);
            }
        }
        static void Main(string[] args)
        {
            var firstNames = ReadList("first names");
            var lastNames = ReadList("last names");
            var fullNames = new List<string>();

            foreach(var first in firstNames)
            {
                foreach(var last in lastNames)
                {
                    fullNames.Add(first + " " + last);
                }
            }

            foreach(var it in fullNames)
            {
                Console.WriteLine(it);
            }
        }
    }
}
