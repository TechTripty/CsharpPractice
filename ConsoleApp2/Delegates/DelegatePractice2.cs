using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.Delegates.DelegatePractice;

namespace ConsoleApp2.Delegates
{
    internal class DelegatePractice2
    {
        public delegate void DisplayDelegate(int x , int y);
        public delegate string DisplayDelegate1(string name);

        public void AddNums(int x, int y)
        {
            Console.WriteLine(x + y);
        }


        public static string SayHello(string name)
        {
            return name;
        }


        static void Main(string[] args)
        {

            DelegatePractice2 comingInstance = new DelegatePractice2();
            DisplayDelegate fromDelegate = comingInstance.AddNums;
            fromDelegate(10, 20);

            DisplayDelegate1 dis1 = new DisplayDelegate1(SayHello);
            var s =dis1("John");
            Console.WriteLine(s);

        }
        }
}
