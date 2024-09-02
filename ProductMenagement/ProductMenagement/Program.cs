using ProductMenagement.Models;
using ProductMenagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductMenagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Winkel winkel = new Winkel();
            winkel.AddProduct(new Product("Cola", 1.5, 160, Categories.Dranken));
            winkel.AddProduct(new Product("Apples", 1.5, 120, Categories.Fruit));
            winkel.AddProduct(new Product("Fanta", 1.5, 150, Categories.Dranken));
            winkel.AddProduct(new Product("Makaroni", 1.1, 110, Categories.Pasta));
            winkel.AddProduct(new Product("Peren", 1.8, 200, Categories.Fruit));
            winkel.AddProduct(new Product("Chips", 1.2, 200, Categories.Snack));


            //Console.WriteLine(Helpers.Lijn(50));
            //winkel.ToonVoorraad();
            //Console.WriteLine(Helpers.Lijn(50));

            //winkel.VerwijderProduct("Fanta");
            //Console.WriteLine(Helpers.Lijn(50));
            //winkel.ToonVoorraad();
            //Console.WriteLine(Helpers.Lijn(50));

            Console.WriteLine(Helpers.Lijn(50));

            winkel.UpdateProduct("Cola", "Fanta");
            winkel.ToonVoorraad();
            Console.WriteLine(Helpers.Lijn(50));
        }
    }
}
