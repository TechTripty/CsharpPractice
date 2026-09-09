using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Continue
{
    internal class CountinueBasic
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
               
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("end program");

        }
    }
}
