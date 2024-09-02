using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomX = rnd.Next(0, 10);
            int randomY = rnd.Next(0, 10);
            string[,] array = new string[10, 10];
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(array[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine(randomX);
            Console.WriteLine(randomY);

            bool gameOver = false;
            while (!gameOver)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(array[i, j] = ".");
                    }
                    Console.WriteLine();
                }
                Console.Write("Give X coordinate: ");
                int userX = int.Parse(Console.ReadLine());

                Console.Write("Give Y coordinate: ");
                int userY = int.Parse(Console.ReadLine());

                if (userX == randomY && userY == randomY)
                {
                    Console.WriteLine("game over");
                    gameOver = true;
                }
                else
                {
                    array[randomX, randomY]= "x";
                    if (userX < randomX)
                    {
                        Console.WriteLine("Hoger");
                    }
                    else if (userY > randomY)
                    {
                        Console.WriteLine("Lager");
                    }
                    if (userX > randomX)
                    {
                        Console.WriteLine("Naar recht");
                    }
                    else if(userY > randomY)
                    {
                        Console.WriteLine();
                    }


                    Console.ReadLine();
                    Console.Clear();
                }
            }


        }
    }
}
