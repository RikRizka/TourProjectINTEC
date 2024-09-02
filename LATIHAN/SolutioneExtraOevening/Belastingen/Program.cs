using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Belastingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal texRate = 0.025m;
            decimal mount;
            decimal taxYield;
            string chosen;

            Console.Write("Enter a mount :");
            mount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Does the tax have to be calculate");
            Console.WriteLine("1.yes");
            Console.WriteLine("2.no");
            chosen = Console.ReadLine();

            switch (chosen)
            {
                case "1":
                    taxYield = mount * texRate;
                    break;
            }

        }
    }
}
