using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Calculator  //Kalau banyak maka hanya mauskan <T> di sini
    {
        public static bool AreEqual<T>(T val1, T val2) //T is type
        {
            return val1.Equals(val2);
        }

    }

    //class harus di buat dis sini
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = Calculator.AreEqual(5.5, 5.5);
            if (result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }


}
