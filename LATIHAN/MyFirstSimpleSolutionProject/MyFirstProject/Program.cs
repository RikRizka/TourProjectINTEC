using System;
namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Druk enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("de vier elemet zijn");

            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Water");

            Console.SetCursorPosition(10, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vuur");

            Console.SetCursorPosition(100, 15);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Aardere");

            Console.SetCursorPosition(50, 20);
            Console.ForegroundColor = ConsoleColor.Cyan;   
            Console.WriteLine("Lucht");
            

        }

    }
}
