using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" ");
            string[,] array = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = ".";
                }
            }
            bool gameOver = false;
            Random random = new Random();
            int randomX, randomY;
            Randomize(random, out randomX, out randomY);

            SwohCoordunates(randomX, randomY);
            gameOver = GameLogic(array, gameOver, randomX, randomY);
        }

        private static bool GameLogic(string[,] array, bool gameOver, int randomX, int randomY)
        {
            while (!gameOver)
            {
                ShowHeader(array);
                DrowArray(array);

                int userX, userY;
                UserInput(out userX, out userY);

                if (userX == randomX && userY == randomY)
                {
                    Console.WriteLine("Game over!");
                    gameOver = true;
                }
                else
                {
                    array[userX, userY] = "x";

                    if (userX < randomX)
                    {
                        Console.WriteLine("Hoger!");
                    }
                    else if (userX > randomX)
                    {
                        Console.WriteLine("Lager!");
                    }
                    if (userY < randomY)
                    {
                        Console.WriteLine("rechts!");
                    }
                    else if (userY > randomY)
                    {
                        Console.WriteLine("links!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    SwohCoordunates(randomX, randomY);
                }
            }

            return gameOver;
        }

        private static void UserInput(out int userX, out int userY)
        {
            Console.Write("X coordinaat :");
            userX = int.Parse(Console.ReadLine());
            Console.Write("Y coordinaat :");
            userY = int.Parse(Console.ReadLine());
        }
        private static void Randomize(Random random, out int randomX, out int randomY)
        {
            randomX = random.Next(0, 10);
            randomY = random.Next(0, 10);
        }
        private static void SwohCoordunates(int randomX, int randomY)
        {
            Console.WriteLine(randomX);
            Console.WriteLine(randomY);
        }
        private static void DrowArray(string[,] array)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int j = 0; j < 10; j++)
                {
                    if (array[i, j] == "x")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(array[i, j].PadLeft(4));

                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
        private static void ShowHeader(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(i.ToString().PadLeft(4));
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
