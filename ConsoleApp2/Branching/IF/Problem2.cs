using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.IF
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the S1 students marks:");
            int S1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"first number : {S1}");

            if (S1 <=100 && S1 >= 90)
            {
                Console.WriteLine("grade A");
             
            } else if (S1 < 60 && S1 >= 40)
            {
                Console.WriteLine("grade D");
            }else if (S1 < 90 && S1 >= 75)
            {
                Console.WriteLine("grade b");
            } else if (S1 < 75 && S1 >= 60)
            {
                Console.WriteLine("grade c");
            } else
            {
                Console.WriteLine("fail");
            }

        }

    }
}
