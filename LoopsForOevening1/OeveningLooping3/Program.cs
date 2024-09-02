using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OeveningLooping3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for untuk berkelipatan 
            int number = 20;

            for (int i = 1; i <= number; i++)
            {
                int duaKaliLipat = i * 2;
                int tigaKaliLipat = i * 3;
                int empatKaliLipat = i * 4;

                Console.WriteLine($"{duaKaliLipat} - {tigaKaliLipat} - {empatKaliLipat}");
            }

        }
    }
}
