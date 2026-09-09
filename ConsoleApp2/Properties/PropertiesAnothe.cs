using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Properties
{
    internal class PropertiesAnothe
    {

        // yaha par private constructor nahi hai then we can create instance from other class 


        int radius ;       // member 
        int height ;
        bool status;
        int balance;


        public PropertiesAnothe(int id )
        {
            this.radius = id;
            this.height =500;
            this.balance = 86;
            this.status = false;
        }

        public int _radius
        {
            get { return radius; }      // read only 
        }

        public int _balance
        {
            set { balance = value; }      // write only 
        }
        public int _height
        {
            get { if (balance < 10)
                {
                    return height;       /// read and write
                }
                return 0; }


            set {
                if (balance > 0) {
                    height = value;
                }
                }       
        }
    }
}
