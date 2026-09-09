using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Branching.DoWhile
{
    internal class DoWhilebasic
    {

        static void Main(string[] args)
        {
            int i = 10000;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 100) ;

        }
    }
}
