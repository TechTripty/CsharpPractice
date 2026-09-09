using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int x = 0;
            int highest = 0;
            int secondHighest = 0;


            for (int i = 0; i < 6; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
                //77 55 22 99 88 66

            }
            for (int i = 0; i < arr.Length; i++)   // i =2
            {
                // arr[5](66) > highest = 99
                if (arr[i] > highest) //  condition :- 66>99 // false
                {
                    //secondHighest = 0 
                    secondHighest = highest; // secondHighest = 88
                    highest = arr[i];  // highest =99
                }      // 66 > 88 && 66 != 99
                else if (arr[i] > secondHighest && arr[i] != highest)
                {
                    secondHighest = arr[i];  // secondHighest = 88
                }
            }

            Console.WriteLine();
            Console.WriteLine($"highhest number is :{highest}");
            Console.WriteLine($"second highest  number is :{secondHighest}");

        }
    }
    }

