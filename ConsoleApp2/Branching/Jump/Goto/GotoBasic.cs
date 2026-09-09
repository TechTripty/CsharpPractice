using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ConsoleApp2.Branching.Jump.Goto
{
    internal class GotoBasic
    {

        static void Main(string[] args)
        {
            Console.WriteLine("start");
            goto MyLabel;
            Console.WriteLine("first step ");
            Console.WriteLine("222 step ");
            Console.WriteLine("33 step ");
            Console.WriteLine("55 step ");

        MyLabel:
            Console.WriteLine("second step ");

        }
    }
}
