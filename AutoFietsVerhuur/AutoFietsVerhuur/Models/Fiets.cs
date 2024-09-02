using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFietsVerhuur.Models
{
    public class Fiets : VoerthuigAuto
    {
        public bool HeeftVersnellingen { get; set; }
        public Fiets(string merk, int bouwjaar, int antaldagen, bool heefversneliingen): base(merk, bouwjaar, antaldagen)
        {
           HeeftVersnellingen = heefversneliingen;
            AantalDagen = antaldagen;
        }
        public override void ToonDetails()
        {
            base.ToonDetails();
            Console.WriteLine($"Heeft versnelling: {HeeftVersnellingen}");
            Console.WriteLine($"De huue prijs voor deze fiets is {BerekenHuurprijs(AantalDagen)} voor {AantalDagen} dagen");
          
        }
        public override double BerekenHuurprijs(int aantaldagen)
        {
            double frombase = base.BerekenHuurprijs(aantaldagen);
            return frombase * 8;
        }
        public void RingBel() 
        {
            Console.WriteLine("Ring Ring");
            Console.WriteLine("_____________________________");
        }        



    }
}
