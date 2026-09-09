using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.While
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}
