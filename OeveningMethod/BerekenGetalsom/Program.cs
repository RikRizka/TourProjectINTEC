using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerekenGetalsom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = HitungJumlahAngka(start, end);
            Console.WriteLine(sum);
        }
        static int HitungJumlahAngka (int start , int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum++;
            }
            return sum;
        }
    }
}
