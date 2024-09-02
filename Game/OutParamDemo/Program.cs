using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;  //moet niet en dat kan werken
            int num2 = 20; 
            Add(out num1 , out num2);
            Console.WriteLine($"This is number: {num1} this is num2 {num2}");
        }
        static void Add(out int num1, out int num2)
        {
            num1 = 1;
            num1 += 15; // untuk oud harus deklarasi di di sini dan akan membaca yang di bawah
            num2 = 2;  
        }

    }
}
