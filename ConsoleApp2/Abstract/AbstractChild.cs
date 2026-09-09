using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp2.Abstract
{
    internal class AbstractChild : Abstractbasic
    {
        public override void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public override void Div(int a, int b)
        {
            Console.WriteLine(a / b);

        }

        static void Main(string[] args)
        {

            //Console.WriteLine("i");

            AbstractChild c = new AbstractChild();
            
            c.mul(6, 9);

            c.Div(6, 2);
         


        }
    }
}
