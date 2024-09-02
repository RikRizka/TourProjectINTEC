using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening3.Models
{
    public class Person
    {
        public string Naam /*= "Toto"*/;
        public int Leeftijd;
        public Person() 
        { 

        }

        public Person(string naam) 
        { 
            Naam = naam;
            Leeftijd = 30;
        }
        public override string ToString()
        {
            return $"Name: {Naam} Leeftijd: {Leeftijd}";
        }

    }
}
