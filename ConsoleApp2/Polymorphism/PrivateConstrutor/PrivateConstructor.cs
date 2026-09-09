using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Polymorphism.PrivateConstrutor
{
    internal class PrivateConstructor
    {

        public PrivateConstructor(int i)
        {
            Console.WriteLine("private");
        }
        private PrivateConstructor()
        {
            Console.WriteLine("private");
        }
        //static void Main(string[] args)
        //{
        //    PrivateConstructor e = new PrivateConstructor();
        //}
    }
}
