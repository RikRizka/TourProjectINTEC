using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SortMetProperties
{
    public class Car
    {
        public string Naam { get; set; }
        public int Jaar { get; set; }
        public static IComparer<Car> SortByName
        {
            get
            {
                return new CarsByName();
            }
        }

        public static IComparer<Car> SortByYear
        {
            get
            {
                return new CarsByYear();
            }
        }

        public override string ToString()
        {
            return $" Naam: {Naam} Jaar: {Jaar} oud";
        }

    }
    
}
