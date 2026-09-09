using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.jaggedArray
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[3];
            arr[1] = new int[4];
            arr[2] = new int[2];
            arr[3] = new int[5];
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
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
