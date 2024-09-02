using LibraryValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrarry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test is integar");
            string input = Console.ReadLine();  

            var result = Validator.IsBetween(input);
            Console.WriteLine(result);
        }
    }
}
