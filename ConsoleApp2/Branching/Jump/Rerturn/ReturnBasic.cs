using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Rerturn
{
    internal class ReturnBasic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int status = int.Parse(Console.ReadLine());
            while(status != 0) {
                if (status == 1) {
                Console.WriteLine("program end ");
                    return;
                }
                else
                {
                    Console.WriteLine($"{status}");
                    status = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("i am here ");

        }
    }
}
