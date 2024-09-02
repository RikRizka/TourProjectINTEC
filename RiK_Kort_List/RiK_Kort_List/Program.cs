using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiK_Kort_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product() { Merk = "Fanta", Naam = "Lemon", Volume = "250 ml", Price = 1.25m };
            Product product2 = new Product() { Merk = "Coca-Cola", Naam = "Zero", Volume = "1000ml", Price = 3.30m };
            Product product3 = new Product() { Merk = "Sprite", Naam = "Standard", Volume = "250 ml", Price = 1.25m };
            Product product4 = new Product() { Merk = "Ice-Tea", Naam = "Lipton", Volume = "250 ml", Price = 1.25m };
            Product product5 = new Product() { Merk = "Coca-Cola", Naam = "Light", Volume = "250 ml", Price = 1.50m };
            Product product6 = new Product() { Merk = "Fanta", Naam = "Zero", Volume = "1000ml", Price = 3.30m };
            Product product7 = new Product() { Merk = "Sprite", Naam = "Zero", Volume = "1000ml", Price = 3.30m };
            Product product8 = new Product() { Merk = "CocaCOla", Naam = "Lemon", Volume = "1000ml", Price = 3.30m };
            Product product9 = new Product() { Merk = "Fanta", Naam = "Lemon", Volume = "250 ml", Price = 1.25m };
            Product product10 = new Product() { Merk = "Coca-Cola", Naam = "Zero", Volume = "1000ml", Price = 3.30m };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);
            products.Add(product9);
            products.Add(product10);
            products.Sort();
            products.Reverse();

            foreach (Product product in products)
            {

                Console.WriteLine($"{product.GetCode()} {product.Price}");

            }

            // Console.WriteLine(product1.Naam);
            //Console.WriteLine(product10);
            //Console.WriteLine(product2);    
            //Console.WriteLine(product3);
            //Console.WriteLine(product4);
            //Console.WriteLine(product5);
            //Console.WriteLine(product6);
            //Console.WriteLine(product7);
            //Console.WriteLine(product8);
            //Console.WriteLine(product9);
            //Console.WriteLine(product10);

        }
    }
}
