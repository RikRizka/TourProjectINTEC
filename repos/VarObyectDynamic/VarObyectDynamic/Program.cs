using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarObyectDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object obj;
            obj = 45;
            obj = "Hello";
            obj = null;
                      
            dynamic dyn = 45; //tapu bkan object
        }
        private static void Print (object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
