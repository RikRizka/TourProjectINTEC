using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF6_lean
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step into, in een functie stappen om die code te bekijken
            //Step over voert de volledige functie uit en stopt erna 
            //Step out voert de overige code van de huidige functie uit

            Console.WriteLine("Wat is de kilometerstand bij het begin van de rit?");
            int kmBegin = int.Parse(Console.ReadLine());

            Console.WriteLine("Wat is de kilometerstand bij het einde van de rit?");
            int kmEinde = int.Parse(Console.ReadLine());

            Console.WriteLine("hoeveel liter heeft u getankt?");
            int litersBrandstof = int.Parse(Console.ReadLine());

            int aantalKm = kmEinde - kmBegin;
            //uitkomst klopt niet, casten naar float vergeten ~~> tonen breakpoints
            float litersBrandstofPer100Km = (litersBrandstof / aantalKm) * 100;//litersbrandstof/aantalKm --> liter per km //maal 100 --> liter per 100km
            //uitkomst gaat wel kloppen 1 van de 2 gecast naar float, beide worden floats
            //float litersBrandstofPer100Km = ((float)litersBrandstof / aantalKm) * 100;
            //breakpoint na deze code zetten

            Console.WriteLine("Uw verbruik was {0} liter/100km", litersBrandstofPer100Km);
            Console.ReadLine();
        }
    }
}
