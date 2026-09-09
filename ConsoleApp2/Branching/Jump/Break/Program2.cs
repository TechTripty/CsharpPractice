using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Break
{
    internal class Program2
    {
        static void Main(string[] args)
        {   
            int attempts = 0;
            int correctpassword = 1234;

            while(attempts < 3)
            {
                Console.WriteLine("enter password:");
                int password;
                password = int.Parse(Console.ReadLine());
                attempts++;
                if (password == correctpassword)
                {
                    Console.WriteLine("correct");
                    break;
                }else
                {
                    Console.WriteLine("Access Denied");
                }

            }
           
        }
    }
}



