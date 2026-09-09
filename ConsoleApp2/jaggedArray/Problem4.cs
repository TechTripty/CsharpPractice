using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.jaggedArray
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            int even = 0;
            int odd = 0;
            int[][] tipu = new int[3][];
            tipu[0] = new int[5];
            tipu[1] = new int[7];
            tipu[2] = new int[6];
            for (int i = 0; i < tipu.GetLength(0); i++)
            {
                for (int j = 0;j< tipu[i].Length; j++)
                {
                    tipu[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < tipu.GetLength(0); i++)
            {
                for (int j = 0; j < tipu[i].Length; j++)
                {
                    if (tipu[i][j] % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                    Console.Write(tipu[i][j] + " ");


                }
                Console.WriteLine($"total number of even number = {even}");
                Console.WriteLine($"total number of odd number = {odd}");
                even =0; 
                odd = 0;
            }



        }

    }
}
