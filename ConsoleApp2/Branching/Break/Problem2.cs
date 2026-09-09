using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp2.Branching.Break
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the month number:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"enter the month name:");



            switch (month)
            { 
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("winter");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("summer");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("monsoon");
                    break;
                case 11:
                case 10:
              
                    Console.WriteLine("autum");
                    break;
                default:
                    Console.WriteLine("invalid month:");
                    break;

            }
        }
    }
}
