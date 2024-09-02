using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in: ");
            string input = Console.ReadLine();
            int getal = Int32.Parse(input);

            Console.WriteLine("Het kwadraat is: {0}", getal * getal);
            Console.WriteLine("De derde macht is: {0}", getal * getal *getal);
           
            Console.ReadKey();
        }
    }
}
