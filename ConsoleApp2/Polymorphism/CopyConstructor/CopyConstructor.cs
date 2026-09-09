using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Polymorphism.CopyConstructor
{
    internal class CopyConstructor
    {
        int id;
        string Name;
        double Balance;
        public CopyConstructor(int id)
        {
            this.id = id;
            this.Name = "tripty";
            this.Balance = 789758;

        }

        public CopyConstructor(CopyConstructor cd )
        {
            this.id = cd.id;
            this.Name = cd.Name;
            this.Balance = cd.Balance;

        }
        public void display()
        {
            Console.WriteLine($"id:{id} ; name : {Name} ; balance : {Balance}");
        }
        static void Main(string[] args)
        {
            CopyConstructor c = new CopyConstructor(1);
            Console.WriteLine(c.id);
            Console.WriteLine(c.Name);
            Console.WriteLine(c.Balance);

            //cpy.display();
            CopyConstructor d = new CopyConstructor(c);
            //d.display();


        }
        }
}



