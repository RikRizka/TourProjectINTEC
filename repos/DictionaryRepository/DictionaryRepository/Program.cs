using DictionaryRepository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictList = new ProductMenager();
            var list = dictList.SelecAll();
            Show(list, "All products is original order");
            var mySortedList = list.ToList();

            mySortedList.Sort((pair1, pair2) => pair1.Value.Name.CompareTo(pair2.Value.Name));
            Show(mySortedList.ToDictionary(pair => pair.Key, pair => pair.Value), "All products sorted by name");

            //Delit record 2
            dictList.Delete(2);
            Show(dictList.SelecAll(), "All products after deletemimg product with id 2");

            //Add new record
            Product p8 = new Product()
            {
                Id = 8,
                Category = "Computer",
                Name = "Laptop",
                Price = 600.00m
            };
            dictList.Insert(p8);
            Show(dictList.SelecAll(), "All product after adding new product");

            //Update Record
            Product p4 = new Product()
            {
                Id = 4,
                Category = "ComputerUpdate",
                Name = "LaptopUpdate",
                Price = 999.99m
            };
            dictList.Insert(p4);
            Show(dictList.SelecAll(), "All product after update");

            //Select singel recor
            Product p5 = dictList.SelectSingle(5);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Product with id 5 is: " + p5.ToString());
            Console.WriteLine(new string('-', 50));

            //Create two obkect of Product test equal and Hascode
            Product p1 = new Product()
            {
                Id = 10,
                Category = "Telephone",
                Name = "GSM",
                Price = 400.00m
            };
            Product p2 = new Product()
            {
                Id = 15,
                Category = "Telephone",
                Name = "GSM",
                Price = 600.00m
            };
            
            var equal = p1.Equals(p2);
           // Console.WriteLine(p1.Equals(p2));
           if (equal)
            {
                Console.WriteLine("Product already exist in data base");
            }
           else
            {
                dictList.Insert(p2);
            }
           Show(dictList.SelecAll(),"All product after eding bew product");

            //find
            if (dictList.Find(25))
            {
                Console.WriteLine("Product with id 25 exist in database");
            }
            else
            {
                Console.WriteLine("Product with id 25 does not exit in database");
            }
        }
       
       


        private static void Show(Dictionary<int, Product> dicList, string parameter)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(parameter);
            Console.WriteLine(new string('-', 50));
            foreach (var item in dicList)
            {
                Console.WriteLine(item.Key.ToString().PadRight(7) + item.Value.Name.ToString().PadRight(30) + item.Value.Price);
            }
        }
    }
}
