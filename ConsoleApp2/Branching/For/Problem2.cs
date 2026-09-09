using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp2.Branching.For
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i<=100; i++)
            {
                sum += i;
                
            }
            Console.WriteLine(sum);

        }
    }
}
