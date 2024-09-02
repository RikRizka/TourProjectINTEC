using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLoopOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menghitung mundur mulai dari angka 10

            int run = 10;

        while (run > 0 ) 
            {
                Console.WriteLine(run);
                run--;
            }
            Console.ReadLine();
        }
    }
}
