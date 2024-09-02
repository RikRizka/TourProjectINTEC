using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoringMaken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray; 
            
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("left");

            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("right");

            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("top");

            Console.SetCursorPosition(15, 15);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("bottom");
            Console.ReadLine();
        }
    }
}
