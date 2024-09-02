using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestenLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scrijf een .NET-programa dat de gebruike vraagt om drie getallen in te voeren:

            //Console.WriteLine("Please enter 3 numbers");
            ////int bigestNumber = 0;

            ////int.MinValue; // minVallue -12131213
            //for (int i = 1; i < 4; i++)
            //{
            //    Console.Write($"number {i}: " );
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number > bigestNumber)
            //    {
            //        bigestNumber=number;
            //    }
            //}
            //Console.WriteLine("The biggest number is " + bigestNumber);
            //Console.ReadLine();

            Console.WriteLine("Please enter 3 numbers");
            int min = int.MaxValue; // minVallue -12131213
            for (int i = 1; i < 4; i++)
            {
                Console.Write($"number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine("The small number is " + min);
            Console.ReadLine();
        }
    }
}
