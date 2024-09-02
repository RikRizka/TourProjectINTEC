using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string zin = "het is mooie weer in Barcelona";
            //Console.WriteLine(zin.Length);
            //bool letterV = zin.Contains("v");
            //Console.WriteLine(letterV);




            //for (int i = 0; i < zin.Length; i++)
            //{
            //    Console.WriteLine(zin[i]);
            //}
            int som = 0;
            for (int x = 0; x < 10; x++) 
            {
                Console.WriteLine("x= " + x);
                som *= x;
                Console.WriteLine("som= " + som);
            }

            Console.WriteLine($"{som}");
        }
    }
}
