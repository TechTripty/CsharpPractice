using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Break
{
    internal class BreakBasic
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) { 
                  Console.WriteLine(i);
                if (i == 5) {
                    break;
                }
            }

            Console.WriteLine("end program");

        }
    }
}
