﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg
{
    public class Person
    {
        public string  Naam { get; set; }
        public int Leeftijd { get; set; }

        public Person (string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }   
    }
}
