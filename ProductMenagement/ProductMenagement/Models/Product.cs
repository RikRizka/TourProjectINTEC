using ProductMenagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMenagement.Models
{
    public class Product
    {
        
        
            public string Name { get; set; }
            public double Prijs { get; set; }
            public Categories Categorie { get; set; }
            public int Voorraad { get; set; }

        public Product(string name, double prijs, int voorraad, Categories categorie)
        {
            Name = name;
            Categorie = categorie;
            Prijs = prijs;
            Voorraad = voorraad;
         }

    
        public override string ToString()
        {
            return ($"Product: {Name} Categori: {Categorie} Prijs: {Prijs} Voorraad: {Voorraad}");
        }
    }
   
    
}
