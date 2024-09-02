using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisPlay("Rik", 30, 1.65);
        }
        static void DisPlay(string name, int age, double hight, string address ="Brussel")
        {
            Console.WriteLine($"{name} {age} {hight} {address} ");
        }
    }
}
