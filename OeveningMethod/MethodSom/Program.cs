using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSom
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            BrekenSom(5, 5 ," rik");
            Console.ReadLine();
        }
        static void BrekenSom (int a, int b, string c) 
        {
            Console.WriteLine($"Som van {a} + {b}: {a + b + c }");
        }    
    }
}
