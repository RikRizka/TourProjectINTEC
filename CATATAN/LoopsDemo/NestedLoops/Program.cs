using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            for (x = 0; x < 9; x++)
            {
                for (y = 0; y < 9; y++)
                {
                    Console.WriteLine($"{x} {y}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
