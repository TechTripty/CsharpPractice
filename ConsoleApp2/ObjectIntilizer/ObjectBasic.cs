using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ObjectIntilizer
{
    public class ObjectBasic
    {
        int _id;
        string _name;
        int _age;

        //public ObjectBasic(int a, string b , int c)
        //{
        //    this._id = a;
        //    this._name = b;
        //    this._age = c;
        //}

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        static void Main(string[] args)
        {
            //ObjectBasic o = new ObjectBasic(10,"ggg",22);
            ObjectBasic o = new ObjectBasic { id =11 , name = "tripty" , age = 21 };
            Console.WriteLine(o.name);

        }
        }
}
