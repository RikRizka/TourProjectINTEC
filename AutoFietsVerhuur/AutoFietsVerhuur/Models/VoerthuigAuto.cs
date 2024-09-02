using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFietsVerhuur.Models
{
    public class VoerthuigAuto
    {
        public string Merk { get; set; }
        protected int Bouwjaar { get; set; }
        protected int AantalDagen { get; set; }

        public VoerthuigAuto(string merk, int bouwjaar, int antaldagen)
        {
            Merk = merk;
            Bouwjaar = bouwjaar;
            AantalDagen = antaldagen;

        }
        public virtual void ToonDetails()
        {
            Console.WriteLine($"Merk: {Merk} Bouw jaar: {Bouwjaar}"                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 );
        } 
        public virtual double BerekenHuurprijs(int aantaldagen)
        {
            return aantaldagen * 5;// aantaldagen * prijs ( int dit geva; de prijs 5eu
        }
    }
}
