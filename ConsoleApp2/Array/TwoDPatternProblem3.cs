using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class TwoDPatternProblem3
    {
        static void Main(string[] args)
        {
            int increse = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(increse ++);
                }
                Console.WriteLine();
            }
        }
    }
}
