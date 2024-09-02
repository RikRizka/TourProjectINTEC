using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF4
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.141592f;
            Console.WriteLine("Geef de straal van de cirkel in: ");
            string input = Console.ReadLine();
            float straal = float.Parse(input);

            Console.WriteLine("De omtrek van de cirkel is: {0}", 2 * straal * PI);
            Console.WriteLine("De oppervlakte van de cirkel is: {0}", straal * straal * PI);
            Console.ReadKey();
        }
    }
}
