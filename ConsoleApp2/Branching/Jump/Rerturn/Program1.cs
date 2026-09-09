using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Rerturn
{
    internal class Program1
    {
        static int FindHighest(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            } else if(b > c && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
            
        }


        static void Main(string[] args)
        {
            int i = Program1.FindHighest(10, 55, 66);
            Console.WriteLine(i);
        }
    }
}
