using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de kilometerstand bij het begin van de rit?");
            string input = Console.ReadLine();
            int kmBegin = Int32.Parse(input);

            Console.WriteLine("Wat is de kilometerstand bij het einde van de rit?");
            input = Console.ReadLine();
            int kmEinde = Int32.Parse(input);

            Console.WriteLine("hoeveel liter heeft u getankt? ");
            input = Console.ReadLine();
            float litersBrandstof = float.Parse(input);

            int aantalKm = kmEinde - kmBegin;

            float litersBrandstofPerKm = litersBrandstof / aantalKm;
            float litersBrandstofPer100Km = litersBrandstofPerKm * 100;

            Console.WriteLine("Uw verbruik was {0} liter/100km", litersBrandstofPer100Km);
            Console.ReadKey();
        }
    }
}
