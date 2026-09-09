using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.For
{
    internal class Problem1
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("enter the  number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"first number : {num1}");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num1*i}");
            }
        }

    }
}
