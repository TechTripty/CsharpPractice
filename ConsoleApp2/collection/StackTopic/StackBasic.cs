using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp2.collection.StackTopic
{
    internal class StackBasic
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push("hello");
            s.Push(false);
            s.Push(1);
            s.Push(2);
            s.Push("hello");
            s.Push(false);
            // lifo

            foreach (var item in s) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            s.Pop();

            foreach (var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($" no of item in stack :{s.Count}");
        }
        }
}
