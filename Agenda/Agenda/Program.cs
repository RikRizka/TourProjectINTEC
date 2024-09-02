using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    
    internal class Program
    {
       static bool menu = true;
       static string lijn = (new string('-', 115));
        static void Main(string[] args)
        {
            //string[] dag = Enum.GetNames(typeof(Daggen));
            //foreach (var i in dag)
            //{
            //    Console.Write($"\t{i.PadLeft(10)}");
            //}
           // GetUuren();
            ToonMenu(menu);
        }
        static void GetUuren()
        {
    
          ////  Console.WriteLine($"\n{lijn}");
          //  for (int i = 0; i < 24; i++)
          //  {
          //      Console.WriteLine($"{i}u");
          //  }
        }
        static void ToonMenu(bool menu)
        {
           
            while (menu)
            {
                Console.WriteLine("1. Add Agenda");
                Console.WriteLine("2. Show Agenda");
                Console.WriteLine("0. Exit");
                string chosen = Console.ReadLine();
                switch (chosen)
                {
                    case "1":
                        
                        break;
                    case "2":
                        string[] dag = Enum.GetNames(typeof(Daggen));
                       
                        foreach (var i in dag)
                        {
                            Console.Write($"\t{i.PadLeft(10)}");
                            
                        }
                        Console.WriteLine(lijn);
                        GetUuren();
                        break;
                    case "0":
                        menu = false;
                        break;
                }

            }
           
        }
       
    }
}
