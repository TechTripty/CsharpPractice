using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Break
{
    internal class BreakCondition
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the roll no:");
            int roll = int.Parse(Console.ReadLine());
            switch (roll)
            {
                case 1:
                    Console.WriteLine("Tripty");
                    break;
                case 2:
                    Console.WriteLine("summu");
                    break;
                case 3:
                    Console.WriteLine("summie");
                    break;
                default:
                    Console.WriteLine("Tipu sultan");
                    break;
            }
        
        }
        }
}
