using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Polymorphism
{
    internal class OverloadingParent
    {
        public void show()
        {
            Console.WriteLine(" without parameter");
        }

        public virtual void show(int i)
        {
            Console.WriteLine($"with parameter from parent class :" + i);
        }
    }
}
