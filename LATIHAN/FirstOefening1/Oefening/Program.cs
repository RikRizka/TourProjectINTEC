using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int born;
            int thisYear;

            Console.Write("Please enter your name : ");
            name = Console.ReadLine();

            Console.Write("When u were born : ");
            born = int.Parse(Console.ReadLine());
            thisYear = 2023 - born;

            Console.WriteLine($"you have wrote {name} and {born}");
            Console.WriteLine($" {name} you are {thisYear} years old");
            Console.Read();

            #region
            //int huidigeJaar = 2014;
            //Console.WriteLine("Geef uw naam in: ");
            //string naam = Console.ReadLine();
            //Console.WriteLine("Geef uw geboortejaar in: ");
            //string input = Console.ReadLine();
            //int geboortejaar = Int32.Parse(input);
            //int leeftijd = huidigeJaar - geboortejaar;

            //Console.WriteLine("Dag {0}, u bent {1} jaar.", naam, leeftijd);
            //Console.ReadKey();
        }
        #endregion
    
    }
}
