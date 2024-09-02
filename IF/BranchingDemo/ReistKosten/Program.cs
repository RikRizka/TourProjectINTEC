using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReistKosten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prijs;
            Console.Title = "Reistkkosten App";
            Console.WriteLine("Breken uw reiskosren");
            Console.WriteLine("Hoe wenst u te reizen??\n\ta:\tauto\n\tt:\ttrein\n\tv:\tvligtuig");

            string vervoer = Console.ReadLine();
            if (vervoer.ToLower () == "a")
            {
                Console.WriteLine("Gbruik u eigen wagen of een huur wagen");
                Console.WriteLine("\te\teigen wegen");
                Console.WriteLine("\th\teigen wegen");

                string vervoerWagen = Console.ReadLine();
                if (vervoerWagen.ToLower() == "h")
                {
                    prijs = 100;
                }
                else
                {
                    prijs = 0;
                }
            }
            else if (vervoer.ToLower() == "t")
            {
                prijs = 120;
            }
            else if (vervoer.ToLower() == "v")
            {
                prijs = 140;
            }
            else
            {
                prijs = 0;
            }
            Console.WriteLine($"De prijs va reis is $ {prijs}");
            Console.ReadLine();

        }
    }
}
