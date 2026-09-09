using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class ArrayBasic
    {
        static void Main(string[] args)
        {


            int[] arr = new int[6];
            int x = 0;

            for (int i = 0; i < 6; i++)
            {
                x += 10;
                arr[i] = x;
            }
            for (int i = 0;i<6;i++)
            {
                // default value for each place in array is zero
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
        }
    }

