using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class TwoDProblem1
    {
        static void Main(string[] args)
        {
            int sumColumn = 0;
            int sumRow = 0;
            int[,] arr = { {1,2,3,4},
                           {5,6,8,9},
                           {9,9,0,4},
                           {22,4,5,9}};

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j]);

                    sumRow += arr[i, j];

                }
                Console.WriteLine();
                Console.WriteLine( $"sum of row: { sumRow}");
                sumRow = 0;

                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    sumColumn += arr[k, i];

                }
                Console.WriteLine();
                Console.WriteLine($"sum of column: {sumColumn}");
                sumColumn = 0;

            }
        }
    }
}
