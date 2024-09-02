using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gagal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            string[] maanden = new string[]{"jan","feb", "Mart", "Apr", "mei","jun",
                "jul","agus","sep","okt", "Nov","Dec"};

            //Array.Reverse(maanden);
            ////foreach (var item in maanden)

            //string[] kopie = new string[maanden.Length];
            //Array.Copy(maanden, kopie, maanden.Length);

            //foreach (var item in kopie)
            //{
            //    Console.WriteLine(item);
            //}
            //string lijn = new string('-', 40);
            //Console.WriteLine(lijn);

            string zoekterm = "jun".ToUpper();
            int index = Array.IndexOf(maanden, zoekterm);

            Console.WriteLine(index);
            if (index == -1)
            {
                Console.WriteLine("the item is not found");
            }
            else
            {
                Console.WriteLine(maanden[index]);


                //double[] doubles = new double[] { 2, 5, 8, 15, 7, 0, 18, 6.0m };   .

                //for ( i = 0; i < maanden.Length; i++)
                // {
                //     if (maanden == feb)
                //     {
                //         maanden[i] = "Februarry";
                //     }
                //     Console.WriteLine(maanden[i]);
                // }
                // Console.WriteLine("1 yaar maand is: " +i );.
            }
        }
    }
}
