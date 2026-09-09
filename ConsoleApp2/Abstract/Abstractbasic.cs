using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Abstract
{
    internal abstract class Abstractbasic     // abstract class 
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public abstract void mul(int a, int b);    // abstract method 

        public abstract void Div(int a, int b);
        
       
    }
}
