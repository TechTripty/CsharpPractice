using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp2.collection.StackTopic
{
    internal class QueueBasic
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("g");
            q.Enqueue(1.4);
            q.Enqueue("%");
            q.Enqueue(false);

            foreach (var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            q.Dequeue();
            foreach (var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine($" no of item in stack :{q.Count}");
        }
    }
}
