using ClassLibraryLinQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable <Product> products = Product.GetAllProducts();

        //    IEnumerable<Product> selectProduct = from p in products
        //                                         where p.Price >= 400
        //                                         select p;

            List<Product>selectProduct = products.Where(p => p.Price >= 150).ToList();  
            foreach (var product in selectProduct)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
