using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOevening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OddNumOrEven;
            Console.Write("Enter a number");
            OddNumOrEven = Convert.ToInt32(Console.ReadLine());

            if (OddNumOrEven % 2 == 0)
            {
                Console.WriteLine("The number that u put is even number");
            }
            else
            {
                Console.WriteLine("The number that u put is odd number");
                    }
        }
    }
}
