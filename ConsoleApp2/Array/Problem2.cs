using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int x = 0;
            int highest = 0;
            int secondHighest = 0;


            for (int i = 0; i < 6; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());  // assig the value in array index 
                

            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)      // read the array element 
                {   
                   sum += arr[i];
                }
                    
            }
            Console.WriteLine($"sum of even number ={sum}");
        } 
        
    }
}
