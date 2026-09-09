using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Break
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the S1 students marks:");
            int S1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"first number : {S1}");

            switch(S1)
            {
                case <= 100 and >= 90:
                    Console.WriteLine("grade A");
                    break;

                case < 60 and >= 40:
                    Console.WriteLine("grade D");
                    break;

                case < 90 and >= 75:
                    Console.WriteLine("grade B");
                    break;

                case < 75 and >= 60:
                    Console.WriteLine("grade C");
                    break;
                default:
                    Console.WriteLine("fail");
                    break;

            }
        }
    }
}
