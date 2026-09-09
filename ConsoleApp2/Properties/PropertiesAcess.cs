using ConsoleApp2.Polymorphism.PrivateConstrutor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Properties
{
    internal class PropertiesAcess
    {
        static void Main(string[] args)
        {
            PropertiesAnothe p = new PropertiesAnothe(100);
            Console.WriteLine(p._radius);
            //p.radius = 500;
            //Console.WriteLine(p.radius);
            //Console.WriteLine(p._radius);
            //p._height = 666;   // modify 
            Console.WriteLine(p._height);
        }
    }
}
