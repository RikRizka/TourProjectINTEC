using ClassLibraryLinQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lambda_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IEnumerable<Product> getAll = Product.GetAllProducts();
            #region Take
            //IEnumerable<Product> mostExpensive3 =  getAll.OrderByDescending (p => p.Price).Take (3);
            //foreach (Product p in mostExpensive3)
            //{
            //    Console.WriteLine ($"{p.Name} {p.Price}");
            //}
            #endregion

            #region Skip
            //IEnumerable<Product> skipMostExpensive = getAll.OrderByDescending (p=> p.Price).Skip (1);
            //foreach (Product p in skipMostExpensive)
            //{
            //    Console.WriteLine (p.Name + " " + p.Price);
            //}

            #endregion

            #region OrederbyThanBy
            IEnumerable<Product> orederByCategoryThanPrice =
                getAll.OrderBy(p => p.Name).ThenBy(p => p.Price);
            foreach (var p in orederByCategoryThanPrice)
            {
                Console.WriteLine($"{p.Name}  {p.Category} {p.Price.ToString("c")} ");
            }
            #endregion

            #region GroupBy
            Console.WriteLine("-----------------GroupBy-------------------");
            foreach (var group in getAll
                .GroupBy(p => p.Category)
                .Select(group => new { Category = group.Key, Count = group.Count() }) // dia membuat class barau anonimus
                .OrderBy(c => c.Category))
            {
                Console.WriteLine($"{group.Category} {group.Count}");
            };
            #endregion


            #region First
            Console.WriteLine("i");
            Product firstFindLaptop = getAll.First(p => p.Name.ToLower ()== "LaPtop".ToLower());
           if (firstFindLaptop == null)
            {
                Console.WriteLine("No product");
            }
           else
            {
                Console.WriteLine(firstFindLaptop.Name +" "+ firstFindLaptop.Price);
            }
            #endregion

        }
    }
}
