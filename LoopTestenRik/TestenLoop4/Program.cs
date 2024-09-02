using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestenLoop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
                
            Console.Write("Enter a number please: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == j)
                        Console.Write("*");
                }
                Console.Write("");
            }
            Console.ReadLine();
        }
    }
}
