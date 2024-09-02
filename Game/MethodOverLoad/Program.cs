using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate(2, 2);
            Calculate(2, 2, 2);
            Calculate(2, 2, 2.4);
            Calculate(2, 2, "Rik");

            int x = 20;
            x.ToString().PadLeft(5);

        }
        static string Calculate(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("result: " + (a + b));
            return result.ToString();
        }
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("result: " + (a + b + c));
        }
        static void Calculate(int a, int b, double c)
        {
            Console.WriteLine("result: " + (a + b + c));
        }
        static void Calculate(int a, int b, string name)
        {
            Console.WriteLine("result: " + (a + b + " " + name));
        }


    }
}
