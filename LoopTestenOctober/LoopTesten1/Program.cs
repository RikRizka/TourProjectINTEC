
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTesten1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scrijf een .NET-programa dat de gebruike vraagt om drie getallen in te voeren:

            Console.WriteLine("Please enter 3 numbers");
            int biggestNumber = int.MinValue;
            for (int i = 1; i <4; i++) 
            {
                Console.Write($"number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine("The biggest number is " + biggestNumber);
        }
 
    }
}
