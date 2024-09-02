using ClassOefening5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person[] { "Rik", 30 };
            Person person2 = new Person[] { Naam = "Alain" };

            Person person = new Person[] { person1, person2 };
            Console.WriteLine(person);
        }
    }
}
