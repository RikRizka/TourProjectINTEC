using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Groter dan 10");
            List<int> getalen = new List<int>()
            {
                1,2, 3, 4, 8, 10,11,35,69
            };
            var groterNumberDan10 = getalen.Where(x => x > 10).ToList();
            foreach (int item in groterNumberDan10)
            {
                Console.WriteLine(item);
            }
            Line();
            Console.WriteLine("EVEN NUMBER");
            var evenNumber = getalen.Where(x => x % 2 == 0).ToList();
            foreach (int item in evenNumber)
            {
                Console.WriteLine(item);
            }

            Line();
            Console.WriteLine("Find begin with A");

            List<string> Namen = new List<String>()
            {
                "Ric", "Alain", "Deni", "David", "Aldi"
            };
            var NamenMetA = Namen.Where(x => x.ToLower().StartsWith("a")).ToList();
            foreach(string item in NamenMetA) 
            { 
                Console.WriteLine(item);
            }
           

        }
        static void Line()
        {
            Console.WriteLine("-----------------------");
        }
    }
}
