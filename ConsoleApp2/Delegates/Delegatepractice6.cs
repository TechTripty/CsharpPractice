using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp2.Delegates.DelegatePractice;

namespace ConsoleApp2.Delegates
{
    internal class Delegatepractice6
    {
       
        public static int Add(int x, int y)      // func
        {
            return x + y;
        }
        public static void Add2(int x, int y)      /// action
        {
            Console.WriteLine($"hi i ma a action");
        }

        public static bool Add3(int x)     // predicate
        {
            Console.WriteLine($"Add: {x}");
            return true;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> obj = Add;
            var result = obj.Invoke(1,1);
            Console.WriteLine(result);

            Action<int, int> action = Add2;
            action.Invoke(1,1);

            Func<int, bool> obj11 = Add3;
            var resulta = obj11.Invoke(1);
            Console.WriteLine(resulta);
            //Predicate< int> predicate = Add3;
            //var result3 = predicate.Invoke(1);
            //Console.WriteLine(result3);
            //DisplayDelegate1 from1 = Add2;
            //from1(10, 5);
            //DisplayDelegate2 from2 = Add3;
            //var result2 = from2(10, 5);
            //Console.WriteLine(result2);
        }
    }
}
