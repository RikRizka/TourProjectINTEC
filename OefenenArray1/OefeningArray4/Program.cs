using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArray4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInput =  { 2, 4, 8, 55, 1, 5, 7, 11, 12, 22 };

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = i + 1;
                Array.Sort(userInput);
                Console.WriteLine($"no{num} : {userInput[i]}");
            }

            Console.ReadLine();
        }
    }
}
