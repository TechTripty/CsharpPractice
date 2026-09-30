using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp2.collection.StackTopic
{
    internal class ArrayListBasic
    {
        static void Main(string[] args)
        { 
            ArrayList a = new ArrayList();
            Console.WriteLine($" no of item in ArrayList :{a.Capacity}");
            a.Add("a");
            a.Add(1);

            Console.WriteLine($" no of item in ArrayList :{a.Capacity}");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
    }
}
