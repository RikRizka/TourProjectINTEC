using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Everthing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] maanden = {"jan", "feb", "Mart", "Apr", "mei", "jun",
                "jul", "agus", "sep", "okt", "Nov", "Dec"};

            Array.Resize(ref maanden, maanden.Length);

            //int count = maanden.Length;

            for (int i = 0; i < maanden.Length; i++)
            {
                if (i == maanden.Length)
                {
                    Console.WriteLine(maanden[i]);
                }
                else
                {
                    Console.WriteLine(maanden[i] + ",");
                }

            }
              


            //string lijn = new string('-', 40);
            //Console.WriteLine(lijn);

            //string showArray = string.Join("- ", maanden);
            //Console.WriteLine(showArray);

        }
    }
}
