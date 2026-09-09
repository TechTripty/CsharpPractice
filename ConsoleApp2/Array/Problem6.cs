using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class Problem6
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 12, 89, 34, 7, 56, 23 };
            //for (int i = 0; i < arr.Length; i++)   // i =2
            //{
            //    if (arr[i] > highest) 
            //    {
            //        highest = arr[i];  
            //    }      
            int highest = numbers[0];   // 45
            int lowest = numbers[0];
            foreach (int number in numbers)  
            {
                if (number > highest)    // highest 45  true
                {
                    highest = number;
                }
                if (number < lowest)    // lowest 45   true
                {
                    lowest = number;    // 12
                }
            }
            Console.WriteLine($"highest number ={highest}");
            Console.WriteLine($"lowest number ={lowest}");

        }
    }
    }

