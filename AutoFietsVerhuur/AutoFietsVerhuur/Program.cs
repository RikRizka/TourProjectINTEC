using AutoFietsVerhuur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFietsVerhuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VoerthuigAuto> voerthuig = new List<VoerthuigAuto>();
            voerthuig.Add(new Fiets("Gazelle", 2015,2, true));
            voerthuig.Add(new Auto("BMW", 2018, 3 ,4));
            voerthuig.Add(new Fiets("Gazelle", 2017, 4 ,true));
            voerthuig.Add(new Auto("Gazelle", 2019, 5,4 ));

           // Voertuig v1 = new Fiets("Gezelle", 2015, 2, true); // polimervisem

            //foreach (var item in voerthuig) // Polymorphisem met Is keyword
            //{
            //    item.ToonDetails();
            //    if (item is Auto ) 
            //    {
            //        ((Auto)item).start(); //Explicit casting
            //    }
            //    else if (item is Fiets ) 
            //    {
            //        ((Fiets)item).RingBel(); //
            //    }    
            //}

            foreach (var item in voerthuig) // Polymorphisem met Is keyword
            {
                item.ToonDetails();

                Auto auto = item as Auto;
                if (auto != null)
                {
                   auto.start(); //Explicit casting
                }
                else 
                {
                    Fiets fiets= item as Fiets; //
                    if (fiets != null)
                    {
                        fiets.RingBel(); //Explicit casting
                    }
                }
            }
        }
    }
}
