using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopeVariabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x = 276.44;
            double x1 = 236.23;
            double x2 = 424.43;

            double y = 323.43;
            double y1 = 32.42;
            double y2 = 23.324;

            //- dan + hnay untuk ke kiri dan kanan
            Console.WriteLine($"the falue of x is {x,-25:c4} {x1,-15:c2} {x2, -15:c1} ");
            Console.WriteLine($"the falue of x is {y,-25:c4} {y1,-15:c2} {y2,-15:c1} ");
        }
    }
}
