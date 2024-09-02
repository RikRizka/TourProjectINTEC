using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in: ");
            string input = Console.ReadLine();
            int initieelGetal = Int32.Parse(input);

            int uitkomst = initieelGetal + 15;
            uitkomst *= 2;
            uitkomst -= 4;
            uitkomst /= 2;
            Console.WriteLine("Het resultaat is {0}", uitkomst- initieelGetal);

            Console.ReadKey();
        }
    }
}
