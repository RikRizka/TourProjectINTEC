using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherOe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Merk = "BMW";
            auto.Model = "BM200";
            auto.Jaar = 2000;

            Console.WriteLine(auto);

        }
    }
}
