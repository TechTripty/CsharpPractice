using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.jaggedArray
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            int sumRow = 0;
            int maximum = 0;
            int[][] arr = new int[5][];     // 4  its row or no of arrays 
            arr[0] = new int[2];
            arr[1] = new int[4];
            arr[2] = new int[3];
            arr[3] = new int[4];
            arr[4] = new int[5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }

                }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sumRow += arr[i][j];
                    Console.Write(arr[i][j] +" ");


                }
                Console.WriteLine($"hi i am sum of the row{ sumRow}");
                sumRow = 0;
            }
        }
    }
}
