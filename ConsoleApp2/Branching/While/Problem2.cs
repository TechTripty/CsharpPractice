using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp2.Branching.While
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int num1 = int.Parse(Console.ReadLine());   // 10)12345(1234  
            int num2 = num1;       // num2 =1221
            int reversenumber = 0;

            while (num1 > 0)
            {
                int lastdigit = num1 % 10;     // remainder 
                reversenumber = reversenumber * 10 + lastdigit;  //1221
                num1 /= 10;     // quotient

            }   //num1 =0   reversenumber = 1221
            Console.WriteLine($"reversed number = {reversenumber}");
            Console.WriteLine($"our input  number = {num1}");

            if (num2 == reversenumber)
            {
                Console.WriteLine("it is pallindrome");
            }
            else
            {
                Console.WriteLine("it is not a pallidrome");
            }
        }
    }
}
