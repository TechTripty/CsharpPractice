using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.Delegates.DelegatePractice;

namespace ConsoleApp2.Delegates
{
    internal class DelegatePractiec3
    {
        public delegate void DisplayDelegate(int x, int y);
        public void Add(int x, int y)
        {
            Console.WriteLine($"Add: {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Sub: {x - y}");
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Mul: {x * y}");
        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"Div: {x / y}");
        }


        static void Main(string[] args)
        {
            DelegatePractiec3 del = new DelegatePractiec3();
            DisplayDelegate from = del.Add;
            from += del.Sub;
            from += del.Mul;
            from += del.Div;
            from(10, 5);



        }
    }
}
