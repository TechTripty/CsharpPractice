using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Linq;


namespace ConsoleApp2.ExceptionOne
{
    internal class ExceptionBasic
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                Console.WriteLine("enter the value of x");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the value of y");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine($"value of z = {name.Length}");
            }
            catch(Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                Console.WriteLine(" finaaly i am here ");
            }
        }
        }
}
