using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweeDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[0, 3] = 4;

            matrix[1, 0] = 5;
            matrix[1, 1] = 6;
            matrix[1, 2] = 7;
            matrix[1, 3] = 8;

            matrix[2, 0] = 9;
            matrix[2, 1] = 10;
            matrix[2, 2] += 11;

            


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(i); j++)
                {
                    if (i == 2 && j == 2)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    { 
                        Console.WriteLine(" ");
                    }
                   

                }
                Console.ReadLine();
                Console.WriteLine();
                //for (int i = 0; i < matrix.GetLength(0); i++)
                //{
                //    if 

                //for (int k = 0; k < matrix.GetLength(i); k++)
                //{
                //    Console.WriteLine(matrix[k,]);
                //}

            }


        }
    }
}
