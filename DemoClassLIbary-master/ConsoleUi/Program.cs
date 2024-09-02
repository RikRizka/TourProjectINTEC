using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCalculator;

namespace ConsoleUi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first numbers");
            double fn = double.Parse (Console.ReadLine());
            Console.WriteLine("Input second numbers");
            double sn = double.Parse(Console.ReadLine());

            Calculator calc = new Calculator(); 

            Console.WriteLine($"The result of addition is {calc.Add(fn, sn)} ");

            Console.WriteLine($"The result of substraction is {calc.Subtract(fn, sn)} ");
        }
       
    }
}
