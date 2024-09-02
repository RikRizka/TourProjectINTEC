using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEquals
{
    public class Person
    {
        public string Name { get; set; }
        public int Leeftijd { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null|| this.GetType()!=obj.GetType())
            return false;
            if (!(obj is Person)) 
            return false;
            Person p = (Person)obj;
            return (Name == p.Name)&& (Leeftijd == p.Leeftijd);
        
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Leeftijd.GetHashCode();
            //return Name.GetHashCode() ^ Leeftijd.GetHashCode();
        }
    }
}
