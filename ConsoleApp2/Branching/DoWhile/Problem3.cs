using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.DoWhile
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;
            do
            {
                Console.WriteLine("enter a number:");
                int num1 = int.Parse(Console.ReadLine());
                //sum += num1;
                number = num1;

            } while (number != 7);
            //Console.WriteLine($"total sum ={sum}");

        }
    }
}
