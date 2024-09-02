using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuallyCopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] intArray = { 100, 600, 90, 42, 555, 666 };
            int[] copyOfintArray = new int[6];//intArray.Length
            for (int i = 0; i < intArray.Length; i++)
                
            {
                 copyOfintArray[i] = intArray[i];

                Console.WriteLine(intArray[i]);//copyOfintArray[i]);
             
            }
            
        }
    }
}
