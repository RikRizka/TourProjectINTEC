using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Invoice> list = new List<Invoice>();

            var standardInvoice = new Invoice(new StandarDiscount());
            standardInvoice.SubTotal = 100;
            list.Add(standardInvoice);
            Console.WriteLine(standardInvoice.GetTotal());

            Console.WriteLine("-----------------------------------------------");

            var premiumInvoice = new Invoice(new PremiumDiscount()); 
            premiumInvoice.SubTotal = 100;
            list.Add(premiumInvoice);
            Console.WriteLine(premiumInvoice.GetTotal());

            Console.WriteLine("List");
            foreach (var item in list)
            {
                Console.WriteLine(item.GetTotal());
            }
        }
    }
}
