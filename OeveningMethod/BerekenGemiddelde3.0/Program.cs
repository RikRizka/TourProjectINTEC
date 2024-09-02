using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerekenGemiddelde3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 2, 4, 6, 7 };
            double result = ReturnAvarangeArray(array);
            Console.WriteLine(result);
        }
        static double ReturnAvarangeArray(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                sum += array[i];
            }
            sum= sum / array.Length;
            return sum;
        }
    }
}
