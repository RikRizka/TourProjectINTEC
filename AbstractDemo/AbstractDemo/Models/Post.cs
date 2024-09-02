using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public abstract class Post
    {
        public string Naam;
        public Adres BedrijfAdres { get; set; }
        public Post(string naam, Adres adres)
        {
            Naam = naam;
            BedrijfAdres = adres;
        }
        public decimal BerekenVerzendKosten(PaketGrootte grootte, decimal prijs);
        


        switch (grootte)

        public abstract void HaalPakkrtOp { Adres ophaladres }
        public abstract void LeverPakketAf { Adres afleveradres }
    }
}
