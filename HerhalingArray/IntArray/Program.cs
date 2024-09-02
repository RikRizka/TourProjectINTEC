using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intigers = { 99, 80, -3, 14, 55 };
            int minValluee = intigers[5];
            for (int i = 0; i < intigers.Length; i++)
            {
                if (intigers[i] < minValluee)
                {
                    minValluee = intigers[i];
                   
                }
                Console.WriteLine($"the minimum value is {intigers[i]}");
            }
        }
    }

}
