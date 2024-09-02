using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMetProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cards = new Car[5];
            cards[0] = new Car() { Naam = "Audi", Jaar = 2010 };
            cards[1] = new Car() { Naam = "BMW", Jaar = 2012 };
            cards[2] = new Car() { Naam = "Toyota", Jaar = 2014 };
            cards[3] = new Car() { Naam = "Lamborgini", Jaar = 2016 };
            cards[4] = new Car() { Naam = "Tesla", Jaar = 2020 };

            Console.WriteLine( "Unsorted Array  can Car's");
          
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted by name---------------");
            Array.Sort(cards, Car.SortByName);
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted by jaar----------------");
            Array.Sort(cards, Car.SortByYear);
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }

        }
    }
}
