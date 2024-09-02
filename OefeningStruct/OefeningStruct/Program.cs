using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OefeningStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Auto auto = new Auto("Toyota", "TytGT0", 2000);

            //auto.Merk = "Toyota";
            //auto.Model = "TytGT0";
            //auto.Jaar = 2000;

            Console.WriteLine(auto);

        }
    }
}
