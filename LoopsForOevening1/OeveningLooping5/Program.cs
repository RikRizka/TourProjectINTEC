using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace OeveningLooping5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Baca 3 bilangan bulat terletak di antara 10 dan 100 dan cetak mereka
            int max = 3;
            int sum = 0;

            Console.Write("Enter a nube 10 dan 100 : \n");

            for (int i = 1; i <= max; i++)
            {

                Console.Write("Enter a number " + i + " : ");
                int number = int.Parse(Console.ReadLine());
                if (number <= 10 || number > 100)
                {
                    Console.WriteLine("Numbers have to be between 10 and 100");
                }
                else 
                {
                    sum += number;
                }
                Console.WriteLine($"The result of adding the 3 numbers is + {sum} ");
            }

        }

    }
}
