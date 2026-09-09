using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Break
{
    internal class Program1
    {
        static void Main(string[] args)
        { int count = 0;
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());  // 8
            while (num1 < 0 || num1>=0)  //false || true
            {
                if(num1 == 0)   //true
                {
                    break;
                }
                else
                {
                    num1 = int.Parse(Console.ReadLine());   //99  //-4  // 0
                    count++;   // 3
                }
                

            }
            Console.WriteLine($"numbers enter:{count}");

        }
    }
}
