using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Rerturn
{
    internal class Problem2
    {
        static string CheckNumber(int n)   //
        {
            if (n % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        static void Main(string[] args)
        {
            string n = Problem2.CheckNumber(78);
             Console.WriteLine(n);
        }
    }
}
