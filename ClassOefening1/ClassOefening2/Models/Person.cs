using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening2.Models
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
        public override string ToString()
        {
            return $"Naam: {Naam} Leeftijd: {60} ";
        }
    }
}
