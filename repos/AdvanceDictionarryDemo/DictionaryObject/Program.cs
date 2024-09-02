using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryObject
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Size { get; set; }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza() { Id = 1, Name = "Pepperoni", Size = 12 };
            Pizza pizza2 = new Pizza() { Id = 2, Name = "Cheese", Size = 12 };
            Pizza pizza3 = new Pizza() { Id = 3, Name = "Hawaian", Size = 12 };
            Pizza pizza4 = new Pizza() { Id = 4, Name = "Meat Lovers", Size = 12 };
            Pizza pizza5 = new Pizza() { Id = 5, Name = "Vaggie", Size = 12 };
            Pizza pizza6 = new Pizza() { Id = 6, Name = "Pepper", Size = 12 };

            Dictionary<int, Pizza> dictPizza = new Dictionary<int, Pizza>();
            dictPizza.Add(pizza1.Id, pizza1);
            dictPizza.Add(pizza2.Id, pizza2);
            dictPizza.Add(pizza3.Id, pizza3);
            dictPizza.Add(pizza4.Id, pizza4);
            dictPizza.Add(pizza5.Id, pizza5);
            dictPizza.Add(pizza6.Id, pizza6);

            foreach (var kvp in dictPizza)
            {
                Console.WriteLine($"Key {kvp.Key} Value: {kvp.Value.Name} {kvp.Value.Size}");
            }
            Console.WriteLine("The found pizza is");

            Pizza findPizza = new Pizza();
            //if (dictPizza.ContainsKey(7))
            ////{
            //    findPizza = dictPizza[7];
            //    Console.WriteLine(findPizza.Name + " "+ findPizza.Size);
            //}
            //else
            //{
            //    Console.WriteLine("Pizza not found");
            //}
            findPizza = FindPizza(dictPizza);
            Console.WriteLine("Enter pizza pizza code");
            int code = int.Parse(Console.ReadLine());

            Console.ReadLine();



        }

        
    }
}
