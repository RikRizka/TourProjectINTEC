using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zoekInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] products = { "bananas", "peers", "apple", "stroberry", "manggo" };
            double[] prices = { 1.30, 1.5, 2.00, 2.30, 2.70 };
            bool found = false;
            Console.Write("Geef wat product zoek je: ");
            string inputProducts = Console.ReadLine();
            int i = 0;

            for (i = 0; i < products.Length; i++)  //kalau kelebihan maka masukan -1
            {
                if (inputProducts.ToLower() == products[i])
                {
                    found = true; // renspon pada "if" yang di bawah
                    break;
                }

            }
            if (found) // atau true nya di ganti dengan hanya (found)
            {
                Console.WriteLine($"Opgexocte product is {products[i]} and the price is {prices[i]:c}.");
            }
            else
            {
                Console.WriteLine("The product is not find");
            };

            Console.ReadLine();
        }
    }
}
