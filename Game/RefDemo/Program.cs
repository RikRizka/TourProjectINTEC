using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10; // dengan ref harus di sini deklarasinya 
            int num2 = 30;
            add(ref num1, ref num2);
            Console.WriteLine($"This is num1: {num1} {num2}");
        }
        static void add (ref int num1, ref int num2)
        {
            num1 = 1;  //dan akan di baca di sini
            num2 += 20;
        }

    }
}
