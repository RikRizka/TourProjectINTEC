using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oevening1
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
            else if (num1 < num2)
            {
                Console.WriteLine($"the small number is {num1}");
                Console.ReadLine();
            

            }


}

        }
    }

