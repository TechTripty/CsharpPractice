using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Indexer
{
    internal class OneIndex
    {
        static void Main(string[] args)
        {
            TwoIndex t = new TwoIndex(10);
            Console.WriteLine("radius " + t["radius"]);
            t["radius"] = 5555;
            Console.WriteLine("radius " + t["radius"]);

        }
    }
}
