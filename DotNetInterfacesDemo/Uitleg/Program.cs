using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            List<Person> personen = new List<Person>
            {
                new Person ("Jan", 20),
                new Person ("Rik", 30),
                new Person ("Alain", 40),
            };

            foreach (Person person in personen)
            {
                Console.WriteLine(person.Naam + " is " + person.Leeftijd + " Jaar oud");
            }
            #endregion
            //PersonColection personen = new PersonColection();
            //personen.Add(new Person("Jan", 20));
            //personen.Add (new Person ("Jan", 30));
            //personen.Add (new Person ("Jan", 40));
            //foreach (Person person in personen)
            //{
            //    Console.WriteLine(person.Naam + " is " + person.Leeftijd + "Jaar oud");
            //}
            //fpr this case tidak bisa di gunakan jika


        }
    }
}
