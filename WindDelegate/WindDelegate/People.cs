using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindDelegate
{
    public class People
    {
        public static List<Person> GetPeople()
        {
            var p = new List<Person>()
     {
         new Person(){FirstName="Salvatore", LastName="Vella", StartDate = new DateTime(2005,10,25),Rating=6},
         new Person(){FirstName="Hugo", LastName="Sanchez", StartDate = new DateTime(2008,05,17),Rating=6},
         new Person(){FirstName="Dritan", LastName="Kici", StartDate = new DateTime(2005,03,12),Rating=5},
         new Person(){FirstName="Hasan", LastName="Alwehidi", StartDate = new DateTime(2010,09,19),Rating=5},
         new Person(){FirstName="Gabriela", LastName="Richards", StartDate = new DateTime(2005,5,17),Rating=3},
         new Person(){FirstName="Olesia", LastName="Khalota", StartDate = new DateTime(1989,11,24),Rating=6},
         new Person(){FirstName="Zakaria", LastName="Guerbaoui", StartDate = new DateTime(2001,04,13),Rating=2},
         new Person(){FirstName="Eveline", LastName="Leys", StartDate = new DateTime(2008,01,18),Rating=5},
     };

            return p;
        }
    }
}
