using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCalculator; //Naam van project

namespace ConsoleUi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input first number: ");
            double fn = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double sn = double.Parse(Console.ReadLine());
            
           Calculator calculator = new Calculator(); //klau static tidak bisa dengan new

            Console.WriteLine($"The result of add is {calculator.Add(fn,sn)} ");//class.Method (param yg ingin di pang)
            Console.WriteLine($"The result of Substract is {calculator.Substract(fn, sn)} ");

            Console.ReadLine();
        }
       
    }
}
