using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.IF
{
    internal class IfProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of electricity unit consumed :");
            int E1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"E1 number : {E1}");
            

            if (E1> 0 && E1<=100)
            {
                Console.WriteLine($"multiple of the bill: {E1 * 5}");
           
            }else if (E1>100 && E1 <= 200)
            {
                Console.WriteLine($"multiple of  2nd bill: {(E1-100)*7 + 100*5}");
            }
            else
            {
                Console.WriteLine($"total bill:{(E1-200)*10+100*5 +100*7}");
            }
                

        }

        }
}


