using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // minta pengguanak memasukan 2 angka dan periksa apakah keduan nya sama

            Console.Write("Enter first number :");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number :");
            int number2 = int.Parse(Console.ReadLine());
            
            if (number1 == number2) 
            {
                Console.WriteLine("These number are the same");
            }
            else
            {
                Console.WriteLine("These number are not the same");
            }
        }
    }
}
