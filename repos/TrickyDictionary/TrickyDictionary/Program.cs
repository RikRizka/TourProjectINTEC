using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyDictionary
{
    class Subject
    {
        public string Code { get; set; }
        public Subject(String code)
        {
            Code = code;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Subject))
            {
                return false;
            }
            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((Subject)obj).Code);
        }
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code);
        }
    }
    class Professor
    {
        public Subject SubjectCode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Subject, Professor> professors = new Dictionary<Subject, Professor>();

            Professor p1 = new Professor() { Name = "Rik", Age = 20, SubjectCode = new Subject("Math") };
            Professor p2 = new Professor() { Name = "Rek", Age = 21, SubjectCode = new Subject("Eng") };
            Professor p3 = new Professor() { Name = "Ruk", Age = 22, SubjectCode = new Subject("Bio") };

            professors.Add(p1.SubjectCode, p1);
            professors.Add(p2.SubjectCode, p2);
            professors.Add(p3.SubjectCode, p3);

            foreach (var item in professors)
            {
                Console.WriteLine($"Subject: {item.Key.Code} - Professor: {item.Value.Name}");
            }
            Console.WriteLine("----------------------------------------------");

            Console.Write("Enter Code Code please: ");
            var code = Console.ReadLine();

            if (professors.TryGetValue(new Subject(code), out Professor professor))
            {
                Console.WriteLine($"The professor is {professor.Name}");
            }
            else
            {
                Console.WriteLine("Code is not found");
            }

        }
    }
}
