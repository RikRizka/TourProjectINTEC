using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ShowStarInPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            //matrix[2, 2] = "*";
            for (int i = 0; i < matrix.GetLength(0); i++) // 0 - is erste dimenci
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // 1 - is dweede dimenci
                {
                    if (matrix[i, j] == matrix[2, 2])
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("_");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
