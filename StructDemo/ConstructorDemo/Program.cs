using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product() { id = 2, name = "Reem", price = 2.99, stock = 10 };
            Product p2 = new Product(1, "Bread", 2.20, 150);
            Product p3 = new Product(7, "Cheese", 3.99);

            Product[] pruducts = new Product[] { p1, p2, p3 };

            foreach (var product in pruducts)
            {
                Console.WriteLine(product);

            }
            has context menu
            Compose


        }
    }
}
