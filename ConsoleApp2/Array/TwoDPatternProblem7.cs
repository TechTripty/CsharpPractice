using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class TwoDPatternProblem7
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 9; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if ((9 / 2) + 1 >= j)
                    {
                        Console.Write(i);
                    }
                    else if ((9 / 2) + 1 <= j)
                    {
                        {
                            Console.Write(i - (j - (9 / 2) + 1));
                        }




                    }
                    Console.WriteLine();

                }

            }
        }
    }
}
