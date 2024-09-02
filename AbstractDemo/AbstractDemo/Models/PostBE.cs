using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public class PostBE:Post
    {
        public PsotBE(Adres adres) : base(naam, adres)
        {

        }
        public override void HaalPakkrtOp(Adres ophaladres)
        {
            Console.WriteLine($"PostBE haal paket op van {ophaladres}");
        }
        public override void LeverPakketAf(Adres afleveradres)
        {
            Console.WriteLine($"PostBE levert pakket af op {afleveradres}");
        }
        public override void BerekenVerzendKosten(PaketGrootte grootte)
        {
            switch (grootte)
            {
                case PaketGrootte.Klein:
                    return 5.5m;
                case PaketGrootte.Middel:
                    return 10.3m;
                case PaketGrootte.Groot:
                    return 15.9m;
                default


            }
        }
    }
}
