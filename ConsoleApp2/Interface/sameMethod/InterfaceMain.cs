using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Interface.sameMethod
{
    internal class InterfaceMain : Interface2 , Interface1
    {
        public void test()
        {
            Console.WriteLine("hi");
        }
        public void show()
        {
            Console.WriteLine("hello");
        }
        void Interface2.show()
        {
            Console.WriteLine("Interface2");
        }
        static void Main(string[] args)
        {
            InterfaceMain m = new InterfaceMain();
            m.test();
            //m.show();
            Interface2 c = m;
            c.show();

        }

        }
}
