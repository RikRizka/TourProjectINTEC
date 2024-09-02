using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 5, 6, 9, 7 };
            int[] numbers2 = { 6, 4, 2, 1 };
            

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (i == j) 
                    {
                   int result = numbers[i] + numbers2[j];
                   Console.WriteLine(result);

                    }
                }
            }

        }
    }
}
