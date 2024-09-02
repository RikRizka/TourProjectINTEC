using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Program
    {
        static class Person
        {
           
            public static int Count { get; set; } // is niet van instantie karena count sebagain static
            // jadi stati di sinin hanya di membaca di dalam klass bukan pada obyek seperti P. P1 itu adalah Obyek.
            public static string Name { get; set; } // 3 ini adalah Klass dan static hanya membuat di sini
            public static int Age { get; set; }

            public static void DispalayName()
            {
                Console.WriteLine("Name: {0}",Name);
                Console.WriteLine("Age: {0}", Age);
            }    // ini Adalah Methode
           
            static Person()
            {
                Console.WriteLine("Constructor is using only one");
            }

        }
        internal class Person2 
        {
            static void Main(string[] args)
            {
                Person.Name = "John";
                Person.Age = 30;
                Person.DispalayName();

                Person.Name = "Rik";
                Person.Age = 29;
                Person.DispalayName();
            }
        }
       
       
            //Person p = new Person();
            //Person p1 = new Person();
            //Person p2 = new Person();
            //Person p3 = new Person();
            
            //    // Person.Count = 100; //karena member dari class, class niet meer dan blue prient
            //    Console.WriteLine(Person.Count); // kenapa harus Person.count? karena Count is a class jadi harus di panggil dengan 
            //Person.Count
            //Count selalu menjadi Count++

        
    }
}
