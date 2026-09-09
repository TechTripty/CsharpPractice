using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class problem4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int x = 0;
            int highest = arr[0];
            int secondHighest = arr[0];


            for (int i = 1; i < 6; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());     // for loop to assign the array element 
            }
            int sum = 0;
            foreach (int value in arr)      // only read the array element not assign the array element
            {
                Console.WriteLine(value);
            }
            //Console.WriteLine($"sum of even number ={sum}");
        }

    }
}
