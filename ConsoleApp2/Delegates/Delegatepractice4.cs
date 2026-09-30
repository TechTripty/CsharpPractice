using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.Delegates.DelegatePractice;

namespace ConsoleApp2.Delegates
{
    internal class Delegatepractice4
    {
        public delegate void DisplayDelegate(int x, int y);
        static void Main(string[] args)
        {
            //Delegatepractice4 del = new Delegatepractice4();
            DisplayDelegate from = delegate (int x, int y)
            {
                Console.WriteLine($"Add: {x + y}");
            };
            from(10, 5);
        }
    }
}
