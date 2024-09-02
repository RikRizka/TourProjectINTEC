using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[][] studenten = new double[3][];
            studenten[0] = new double[] { 8, 5, 9, 0, 7, 5, 9, 2, 7, 6 };
            studenten[1] = new double[] { 7.0, 8.0 };
            studenten[2] = new double[] { 5.8, 8.3, 7.5, 8.2 };
            for (int i = 0; i < studenten.Length; i++)
            {
                Console.WriteLine($" Cijfers voor student = {i+1}: ");
                for (int j = 0; j < studenten[i].Length; j++)
                {
                    Console.WriteLine($"vak {j} : {studenten[i][j]}");
                }
            }


        }
    }
}
