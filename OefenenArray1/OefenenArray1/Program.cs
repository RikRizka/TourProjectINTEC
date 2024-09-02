using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenenArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 5, 6, 9, 10, 12 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
