using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening5.Models
{
    public class Person
    {
        public string Naam;
        public int Leeftijd;

        public Person(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;

        }
        public Person(string naam)
        {
            Naam = naam;
            Leeftijd = 20;

        }
        public override string ToString()
        {
            return $"Naam: {Naam} Leeftijd: {Leeftijd}";
        }
    }
}
