using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.While
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a nuber :");
            int num1 = int.Parse(Console.ReadLine());

            int count = 0;
            while (num1 > 0)     // 1
            {
                num1 /= 10;     //  0
                count += 1;       //5
            }
            Console.WriteLine($"no of digit ={ count}");
        }
    }
}
