using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\TempTest\TestFile1.txt";

            string[] words = File.ReadAllLines(file);
            Console.Write("Enter the word to be searched: ");
            string search = Console.ReadLine().Trim();


            int position = 0;
            position = Array.IndexOf(words, search);//IndexOf direct emangambil pada position
            position++;

            if (position > 0)
            {
                Console.WriteLine($"Your search term {search} is found in the file. ");
                Console.WriteLine($"Your search is on the line {position}");

            }
            else
            {
                Console.WriteLine("Is not found");
            }

        }
    }
}
