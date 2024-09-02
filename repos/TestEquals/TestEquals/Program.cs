using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "jik", Leeftijd = 23 };
            Person person2 = new Person { Name = "jik", Leeftijd = 23 };
            Person person3 = new Person { Name = "rik", Leeftijd = 25 };

            Console.WriteLine("Use == methode");
            Console.WriteLine();
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person2 == person3);

            Console.WriteLine("Use equals method");
            Console.WriteLine();
            Console.WriteLine("person 1 equals person 2 " + person1.Equals(person2));//true
            Console.WriteLine("person 1 equals person 2 " + person1.Equals(person3));//false

        }
    }
}
