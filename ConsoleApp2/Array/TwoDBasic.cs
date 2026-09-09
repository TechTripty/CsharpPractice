using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Array
{
    internal class TwoDBasic
    {
        static void Main(string[] args)
        {
           
            int[,] arr = { { 10, 20, 30 },
                           { 30, 20, 22 } };
           // int[,] arr = new int[i, j];  i outer loop or rows 
           // j is inner loop or column 

            for (int i = 0; i < 2; i++ ) {
                // i = 1 ; true ; 
                for (int j = 0; j < 3; j++)
                    
                {
                    
                    Console.Write(arr[i, j]);
                     
                    // 102030
                    // 302022
                    
                    

                }
                Console.WriteLine();  // lline break 
                Console.Read();
                
            }
        
        }


        }
}


//read  :- for / foreach
//write :- only for loop 
