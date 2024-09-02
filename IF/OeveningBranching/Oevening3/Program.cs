using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Oevening3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose the number that u want :");
            Console.WriteLine("\t1 : viekant");
            Console.WriteLine("\t2 : driehoek");
            Console.WriteLine("\t3 : Cirkel");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.Write("Enter the side length :");
                int side = int.Parse(Console.ReadLine());
                int result = side * side;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else if (number == 2)
            {
                Console.Write("Enter the hoggte :");
                int hoogte = int.Parse(Console.ReadLine());
                Console.Write("Enter the basis :");
                int basis = int.Parse(Console.ReadLine());
                int result = hoogte * basis / 2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else if (number == 3)
            {
                Console.Write("Enter the Straal :");
                int straal = int.Parse(Console.ReadLine());
                Console.Write("enter Pi");
                int pi = int.Parse(Console.ReadLine());
                int result = straal * straal *pi;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            {
            }

        }
    }
}
