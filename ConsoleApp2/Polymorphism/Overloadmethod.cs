using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Polymorphism
{
    internal class Overloadmethod
    {
        public void show()
        {
           Console.WriteLine(" without parameter");
        }

        public void show(int i)
        {
            Console.WriteLine($"with parameter:"+ i);
        }

        public void show(string s )
        {
            Console.WriteLine($"with parameter string :" + s);
        }

        public void show(int i ,string s)
        {
            Console.WriteLine($"with parameter int and string :" + i  + s);
        }

        public void show(string s ,int i)
        {
            Console.WriteLine($"with parameter string and int :" + s   + i);
        }
        static void Main(string[] args)
        {
            Overloadmethod s = new Overloadmethod();
            s.show();
            s.show(55);
            s.show("tripty");
            s.show(34, "summu");
            s.show("tipu", 78);
        }
    }
}   
