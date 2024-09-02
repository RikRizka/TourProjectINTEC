using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] getallen = new[] {1,2,3,4,5,6,7,8,9};
            //Array.Sort(getallen);
            //foreach (var item in getallen)
            //{
            //    Console.WriteLine(getallen);
            //}

            List<Student> studenten = new List<Student>();
            studenten.Add(new Student("Jan", 18));
            studenten.Add(new Student("Rik", 18));
            studenten.Add(new Student("Alai", 18));

            studenten.Sort();
            foreach (Student student in studenten)
            {
                Console.WriteLine(student);
            }

        }
    }
}
