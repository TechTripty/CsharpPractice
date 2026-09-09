using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp2.Indexer
{
    internal class TwoIndex
    {

        int radius;       // member 
        int height;
        bool status;
        int balance;


        public TwoIndex(int id)
        {
            this.radius = id;
            this.height = 500;
            this.balance = 86;
            this.status = false;
        }

        

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return radius;
                else if (index == 1)
                    return height;
                else if (index == 2)
                    return balance;
                else if (index == 3)
                    return status;
                else
                    return null;
            }

            set
            {
                if (index == 0)
                    radius = (int)value;
                else if (index == 1)
                    height = (int)value;
                else if(index == 2)
                    balance=(int)value;
                else if (index == 3)
                    status = (bool)value;
            }


        }

        public object this[string name]
        {
            get
            {
                if (name == "radius")
                    return radius;
                else if (name == "height")
                    return height;
                else if (name == "balance")
                    return balance;
                else if (name == "status")
                    return status;
                else
                    return null;
            }
            set
            {
                if (name == "radius")
                    radius = (int)value;
                else if (name == "height")
                    height = (int)value;
                else if (name == "balance")
                    balance = (int)value;
                else if (name == "status")
                    status = (bool)value;
            }

        }

        }
}
