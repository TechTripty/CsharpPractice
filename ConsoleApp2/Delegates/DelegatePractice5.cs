using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.Delegates.DelegatePractice;

namespace ConsoleApp2.Delegates
{
    internal class Delegatepractice5
    {
        public delegate void DisplayDelegate(int x, int y);
        public delegate void DisplayDelegate1(int x, int y, int z, int u);
        static void Main(string[] args)
        {
            //lambda expression
            DisplayDelegate from =  (int x, int y)  =>
            {
                Console.WriteLine($"Add: {x + y}");
            };
            from(10, 5);


            DisplayDelegate1 from1 = (int x, int y, int z , int u) =>
            {
                Console.WriteLine($"Add: {x + y + z + u}");
            };
            from1(10, 5, 3, 2);
        }
    }
}
