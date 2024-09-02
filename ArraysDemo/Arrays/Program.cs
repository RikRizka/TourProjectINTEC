using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 dimention

            int size = 5;

            int age = 10;

            int[] intArray = new int[size];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 44;
            intArray[3] = 4;
            intArray[4] = 5;

           for (int i = 0; i <intArray.Length; i++) 
            {
                if (intArray[i] == 2)// testen op waarde van element
                    continue;
                    //intArray[i]
               // if (i == 2) // testen op index of intArray
                {
                    intArray[i] = 33;
                    
                }                

                Console.WriteLine(intArray[i]);
            }
           Console.ReadLine();



            #endregion
        }
    }
}
