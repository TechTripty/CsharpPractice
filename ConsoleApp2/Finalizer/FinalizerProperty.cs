using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Finalizer
{
    internal class FinalizerProperty
    {
        public FinalizerProperty()
        {
            Console.WriteLine("instance is created ");
        }

         ~FinalizerProperty()
        {
            Console.WriteLine("instance is destroyed ");
            Console.WriteLine("instance is destroyed "); 
            Console.WriteLine("instance is destroyed ");
            Console.WriteLine("instance is destroyed ");
            Console.WriteLine("instance is destroyed ");
        }

        static void Main(string[] args)
        {
            FinalizerProperty d1 = new FinalizerProperty(); 
            FinalizerProperty d2 = new FinalizerProperty();
            d1 = null;
            d2 = null;
            GC.Collect();                   // Request garbage collection
            GC.WaitForPendingFinalizers();  // Wait for finalizers to finish
            GC.Collect();
            Console.ReadLine();
        }
        }
}
