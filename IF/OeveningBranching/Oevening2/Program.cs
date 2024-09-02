using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevening2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Eneter second number :");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"the biggest number is {num1}");
            }
            else if (num2 < num1)
            {
                Console.WriteLine($"the small number is {num2}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("these numbers are equal");






            }   
        }
    }
}
