using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFietsVerhuur.Models
{
    public class Auto : VoerthuigAuto
    {
        public int AantalDuren { get; set; }
        public Auto(string merk, int bouwjaar, int aantaldagen, int aantalduren) : base(merk, bouwjaar, aantaldagen)
        {
            AantalDagen = aantaldagen;
            AantalDuren = aantalduren;
        }
        public override void ToonDetails()
        {
            base.ToonDetails();
            Console.WriteLine($"Aantal deuren: {AantalDuren}");
            Console.WriteLine($"De huue prijs voor deze auto is {BerekenHuurprijs(AantalDagen)} voor {AantalDagen} dagen");
        }
        public override double BerekenHuurprijs(int aantaldagen)
        {
           
            return aantaldagen * 35;
        }
        public void start()
        {
            Console.WriteLine("start");
            Console.WriteLine("Auto is gestart");
            Console.WriteLine("--------------------------------------------");
        }

    }
}
