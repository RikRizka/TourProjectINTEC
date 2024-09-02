using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF1
{
    class Program
    {
        static void Main(string[] args)
        {
            int huidigeJaar = 2014;
            Console.WriteLine("Geef uw naam in: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef uw geboortejaar in: ");
            string input = Console.ReadLine();
            int geboortejaar = Int32.Parse(input);
            int leeftijd = huidigeJaar - geboortejaar;

            Console.WriteLine("Dag {0}, u bent {1} jaar.", naam, leeftijd);
            Console.ReadKey();
        }
    }
}
