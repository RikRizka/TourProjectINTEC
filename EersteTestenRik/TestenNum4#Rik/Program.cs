using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestenNum4_Rik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tootalSocon = 5924;
            int hours = tootalSocon / 3600; // 1 = 3600second
            int rest = tootalSocon % 3600;
            int minut = rest / 60;
            int second = rest % 60;
            Console.WriteLine($"U:{hours} M:{minut} S:{second}");




        }
    }
}
