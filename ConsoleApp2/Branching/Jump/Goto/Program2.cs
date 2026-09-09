using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Goto
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {

                goto evennumber;
            }
            if (num1 % 2 != 0)
            {
                goto oddnumber;
            }
        evennumber:
            Console.WriteLine("even number");
            goto End;
        oddnumber:
            Console.WriteLine("odd number");
            goto End;
        End:
            Console.WriteLine("end of program");

        }
    }
}
