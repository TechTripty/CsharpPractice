using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Polymorphism
{
    internal class OverloadingChild : OverloadingParent
    {
        public void show(string s)
        {
            Console.WriteLine($"with parameter string :" + s);
        }

        public void show(int i, string s)
        {
            Console.WriteLine($"with parameter int and string :" + i + s);
        }

        public void show(string s, int i)
        {
            Console.WriteLine($"with parameter string and int :" + s + i);
        }
        public override void show(int i)
        {
            Console.WriteLine($"with parameter from child class :" + i);
        }
        static void Main(string[] args)
        {
            OverloadingChild c = new OverloadingChild();
            c.show(10);

            //OverloadingParent p = c;
            //p.show(10);
        
        }
        }
}
