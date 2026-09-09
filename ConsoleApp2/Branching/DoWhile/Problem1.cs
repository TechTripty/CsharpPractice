using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.DoWhile
{
    internal class Problem1
    {
        static void Main(string[] args)
        {

            int number = 0;
            do
            {
                Console.WriteLine("check numbers:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter number is not zero :{num1}");    
                number = num1;
            } while (number != 0);
            Console.WriteLine("program ended");
           
        }
    }
}
