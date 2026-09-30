using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Delegates
{
    internal class DelegatePractice
{
        public delegate void DisplayDelegate(int i);
        public delegate void DisplayDelegate1(int i, int j);
        public void Display(int i )
        {
            Console.WriteLine($"ffffffff");
        }

        static public void Display1(int i, int j )
        {
            Console.WriteLine($"dfrrfgrfgrf");
        }
        static void Main(string[] args)
        {
            DisplayDelegate1 ff = new DisplayDelegate1(Display1);
            ff(5, 10);

            //DelegatePractice dh = new DelegatePractice();
            //dh.Display();
            //DisplayDelegate del = new DisplayDelegate(dh.Display);
            //del();
            //dh.Display();

            //DelegatePractice.Display1();
        }
        }
}
