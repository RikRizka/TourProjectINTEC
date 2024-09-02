using AbstractDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lijn = new string('-', 50);

            Adres ophaaladres1BE = new Adres("straat A", "Stad A", "101", "Belgie");
            Adres ophaaladres2BE = new Adres("straat B", "Stad B", "102", "Belgie");
            Adres ophaaladres3BE = new Adres("straat C", "Stad C", "103", "Belgie");

            PostBE postBE1 = new PostBE(ophaaladres1BE);
            postrBE1.HaalPakketOp(ophaaladres1BE);
            postrBE1.verzendekosten = postBE1.BerekenVerzendKosten(PaketGrootte.Groot, 15);
            Console.WriteLine(verzendkosten);
            postBE1.LeverPakketAf(op)
        }
    }
}
