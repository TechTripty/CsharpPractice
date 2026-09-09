using ConsoleApp2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Interface
{
    internal class InterfaceChild : InterfaceBasic , InterfacechildTwo
    {
        public void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            InterfaceChild c = new InterfaceChild();
            c.mul(6, 9);
            c.Div(6, 2);
            c.add(6, 9);
            c.sub(6, 2);
        }
    }
}

// abb mereko tensiomn ho raha hai kya karu 