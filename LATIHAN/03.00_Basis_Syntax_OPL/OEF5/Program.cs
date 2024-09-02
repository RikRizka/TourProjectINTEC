using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het eerste getal in: ");
            string input = Console.ReadLine();
            int getal1 = Int32.Parse(input);

            Console.WriteLine("Geef het tweede getal in: ");
            input = Console.ReadLine();
            int getal2 = Int32.Parse(input);

            Console.WriteLine("De som is {0}", getal1 + getal2);
            Console.WriteLine("Het verschil is {0}", getal1 - getal2);
            Console.WriteLine("Het product is {0}", getal1 * getal2);

        }
    }
}
