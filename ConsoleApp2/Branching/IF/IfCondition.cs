using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.IF
{
    internal class IfCondition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int d1 = int.Parse(Console.ReadLine());     // for passsing the value from keyboard
            Console.WriteLine($"first number : {d1}");
            Console.WriteLine("enter the second number");
            int d2 =
                int.Parse(Console.ReadLine());     // for passsing the value from keyboard
            Console.WriteLine($"second number : {d2}");

            //if (d1 > d2)
            //{
            //    Console.WriteLine($"sum of number :  { d1 + d2}");

            //}else if (d1 < d2)
            //{
            //    Console.WriteLine($"difference of number { d2 - d1}");
            //}
            //else
            //{
            //    Console.WriteLine($"equal number");
            //}
            if (d1 > d2)
            {
                Console.WriteLine($"sum of number :  {d1 + d2}");

            }
            else
            {
                Console.WriteLine($"difference of number {d2 - d1}");
            }
            






        }
    }
    
}
