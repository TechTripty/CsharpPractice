using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Goto
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int num1 = int.Parse(Console.ReadLine());    //7
            if (num1 > 0)
            {
                
                goto positive;

            }
             if(num1 < 0)
            {
                goto negative;
            }
            if (num1 == 0)
            {
                goto zero;
            }
        positive:
            Console.WriteLine("positive");
            goto End;
        negative:
            Console.WriteLine("negative");
            goto End;
        zero:
            Console.WriteLine("zero");
            goto End;

        End:
            Console.WriteLine("end of program");
        }
    }
}
