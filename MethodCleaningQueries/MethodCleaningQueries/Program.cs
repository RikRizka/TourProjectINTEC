using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BierenLibrary;

namespace MethodCleaningQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            BierenService service = new BierenService();
            Console.WindowWidth = 100;
            //Console.WriteLine("{0,-20}{1,-100}{2,-20}{3,-20}", "Nummer", "Naam", "Alcohol",
            //"Brouwer");
            //foreach (Bier bier in service.Bieren)
            //{
            //    Console.WriteLine("{0,-20}{1,-100}{2,-20}{3,-20}", bier.BierNr, bier.Naam,
            //    bier.Alcohol, bier.Brouwer);
            //}
            //List<Bier> AlcoholMeerDan7 = service.Bieren.Where(m => m.Alcohol > 7).ToList();
            //foreach (var item in AlcoholMeerDan7)
            //{
            //    Console.WriteLine(item.Brouwer + " " + item.Alcohol);
            //}

            ////2
            //List<Bier> bierenVanJupiler = service.Bieren.Where(m => m.Brouwer.ToLower() == "jupiler").ToList();
            //foreach (var item in bierenVanJupiler)
            //{
            //    Console.WriteLine(item.Brouwer + " " + item.Alcohol);
            //}
            //LINQ query
            //List<Bier> bierenVanJupiler = (from bier in bieren
            //                               where bier.Brouwer.ToLower() == "jupiler"
            //                               select bier).ToList();

            ////3
            //List<Bier> BierNr120 = service.Bieren.Where(m => m.BierNr == 120).ToList();
            //foreach (var item in BierNr120)
            //{
            //    Console.WriteLine(item.Brouwer);
            //}

            //4
            List<Bier> AlcoholMeerDan7 = service.Bieren.Where(m => m.Brouwer == "Jupiler" || m.Alcohol <= 1 ||m.Alcohol == 5).ToList();
            foreach (var item in AlcoholMeerDan7)
            {
               Console.WriteLine(item.Brouwer + " " + item.Alcohol);
            }


        }
    }
}
