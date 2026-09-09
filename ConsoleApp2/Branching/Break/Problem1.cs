using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Break
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"first number : {num1}");

            Console.WriteLine("enter the secong number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"first number : {num2}");
            Console.WriteLine("enter the operator:");
            int op = char.Parse(Console.ReadLine());
            Console.WriteLine($"first number : {op}");
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1 / num2}");
                    break;
                default:
                    Console.WriteLine("please enter valid operator");
                    break;
            }
        }
    }
}
