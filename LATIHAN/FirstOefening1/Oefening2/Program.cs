using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int result;
            int differentce;

            Console.Write("Enter a number :");
            userInput = Int32.Parse(Console.ReadLine());
            result = ((userInput + 15) * 2 - 4) / 2;
            differentce = userInput - result;
            Console.WriteLine($"The result is {result}");
            Console.WriteLine($"The differentce is {differentce}");

            #region Kenan'sAnswer
            Console.WriteLine("Geef een getal in: ");
            string input = Console.ReadLine();
            int initieelGetal = Int32.Parse(input);

            int uitkomst = initieelGetal + 15;
            uitkomst *= 2;
            uitkomst -= 4;
            uitkomst /= 2;
            Console.WriteLine("Het resultaat is {0}", uitkomst - initieelGetal);

            Console.ReadKey();
            #endregion 
        }
    }
}
