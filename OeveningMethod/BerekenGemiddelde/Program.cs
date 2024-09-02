using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerekenGemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrekenGemiddle(2, 4, 6, 7);
            Console.ReadLine(); 
        }
        static void BrekenGemiddle(double a, double b, double c, double d)
        {
            Console.WriteLine($" De gemiddle waarde is: {a + b + c + d / 4}");
        }

    }
}
