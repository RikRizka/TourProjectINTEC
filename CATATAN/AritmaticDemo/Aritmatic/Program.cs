using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 49;
            double number2 = 18.30;
            Console.WriteLine("Round of 10.89 = " + Math.Round(number2));
            Console.WriteLine($"Round of 10.89 = {Math.Round(number2)} ");

            Console.WriteLine($"floor of 10.89{Math.Floor(number2)}");
            Console.WriteLine($"callingof 10.89{Math.Ceiling(number2)}");
            Console.WriteLine($"Truncate 10.89{Math.Truncate(number2)}");

            double number3 = 50;
            Console.WriteLine($"Minimum between 49 and 50 is {Math.Min(number1,number3)}");
            Console.WriteLine($"Minimum between 49 and 50 is {Math.Max(number1,number3)}");

            Console.WriteLine($"power of 3 rised by 5 is {Math.Pow(3,5)}");

            Console.ReadLine();    



        }
    }
}
