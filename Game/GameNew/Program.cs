using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            random
            int userX, userY;
        }
        private static void PopulateArray(string[,] array)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = ".";
                }
            }
        }
        private static void RandoMize(Random random, out int randomX, out int randomY)
        {
            int randomX = random.Next(0, 10);
            int randomY = random.Next(0, 10);

        }
    }
}
