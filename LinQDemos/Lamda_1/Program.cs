using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_1
{
    internal class Program
    {
        class Person
        {
            public int Age { get; set; }
            public int Hight { get; set; }
        }

        static void Main(string[] args)
        {
            #region Numbres
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 9, 4, 234, 54, 14, 654, 3, 4, 5, 6, 7, };
            //Lambda extract even number

            // var oddNUmbers = numbers.Where(n => n % 2 == 0);
            List<int> oodsNumbers = numbers.FindAll(n => n > 0);
            oodsNumbers.ForEach(n => Console.WriteLine(n));

            //foreach (var n in oodsNumbers)
            //{
            //    Console.WriteLine(n);
            //}
            //Line();
            #endregion

            List<Person> person = new List<Person>() // Colection initialiceer
            {
                new Person() {Age = 25, Hight = 160},
                new Person() {Age = 26, Hight = 180},
                new Person() {Age = 23, Hight = 130},
                new Person() {Age = 60, Hight = 190},
            };
            //var hights = person.Where(p => p.Hight > 160).Select(p=> p.Hight).ToList();
            //hights.ForEach(h => Console.WriteLine(h)); //Loop di Lambda

            //foreach (var p in hights)
            //{
            //    Console.WriteLine(p); // ingin menunjukan Hight karene di atas di select p.Hight
            //}

            //AnonimeMethode //tidak lagi banyak di gunnakan
            Console.WriteLine("Anonome Methode with Delegate");

            var filterPersonDelegate = person.Where(delegate (Person p) { return p.Age < 25; }).ToList();
            foreach (Person p in filterPersonDelegate)
            {
                Console.WriteLine(p.Age);
            }

            Line();
            Console.WriteLine("Anonome Methode with Lambda");

            var filterPersonLambda = person.Where(p => p.Age < 25).ToList();
            foreach (Person p in filterPersonDelegate)
            {
                Console.WriteLine(p.Age);
            }

            Line();
            Console.WriteLine("Normal methode with Lamdas");
            var filterWithMerthode = person.Where(Filter).ToList();
            foreach (var p in filterWithMerthode)
            {
                Console.WriteLine(p.Age);
            }
            var peopleClass = from p in person //di bawah ini if lebih dari 50 akan senior begitupun sebaliknya 
                              select new {Category= p.Age >50 ? "Senior": "Adult", Leeftijd = p.Age, Hoogte = p.Hight};
            Console.WriteLine("Anonimus type or Class");
            foreach (var item in peopleClass)
            {
                
                Console.WriteLine(item.Leeftijd + " " + item.Hoogte);
            }
           
        }
        private static void Line()
        {
            Console.WriteLine(new string('-', 40));
        }
        private static bool Filter(Person person)
        {
            return person.Age < 25;
        }
    }
}
