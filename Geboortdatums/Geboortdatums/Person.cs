using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geboortdatums
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public static void CalculateAgeDifference(DateTime otherBirthDate)
        {
            double dayDifference = Math.Abs((Person)otherBirthDate.;
      
        }
       
        
    }
}
