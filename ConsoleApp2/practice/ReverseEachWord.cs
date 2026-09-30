using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practice
{
    internal class ReverseEachWord
    {
        
        static void Main(string[] args)
        {
            string input = "Hello World i am tripty";

            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                string reverse = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i];
                }

                Console.Write(reverse + " ");
            }


        }
    }

}

