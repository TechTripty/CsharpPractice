using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Continue
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            for(int i =1; i<=20;  i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
            // print only odd number