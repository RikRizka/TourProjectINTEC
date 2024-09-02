using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Leeftijd { get; set; }
        public Student(string name, int leeftijd)
        {
            Name = name;
            Leeftijd = leeftijd;

        }
        public override string ToString()
        {
            return $"Naam: {Name} Leeftijd: {Leeftijd} jaar oud ";
        }

        public int CompareTo(Student other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
