using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Geboortdatums
{
    internal class Program
    {
        static void Main()
        {
            Person P1 = new Person("Salvatore", new DateTime(1989, 7, 25));
            Person P2 = new Person("Rik", new DateTime(1989, 8, 25));
            Person P3 = new Person("Gabriella", new DateTime(1989, 9, 25));
            Person P4 = new Person("Huggo", new DateTime(1989, 10, 25));
            Person P5 = new Person("Alain", new DateTime(1989, 11, 25));
            Person P6 = new Person("Reem", new DateTime(1989, 12, 25));
            Person[] people = { P1, P2, P3, P4, P5, P6 };

            Console.WriteLine("Kies een person:");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"{i}.\t{people[i].Name}");
            }
            Console.Write("Voer een bestaand nummer in: ");
            int selectedPersonIndex;
            while (!int.TryParse(Console.ReadLine(), out selectedPersonIndex) || selectedPersonIndex < 0 || selectedPersonIndex > people.Length) ;
            {
                Console.WriteLine(" ");
            }
            Console.Clear();
            Person selectedPerson = people[selectedPersonIndex];
            Console.WriteLine($"Anda memilih {selectedPerson.Name}");
            for (int i = 0; i < people.Length; i++)
            {
                int dayDifference = selectedPerson.CalculateAgeDifference(people[i].BirthDate);
                if (dayDifference > 0)
                {

                   
                    Console.WriteLine($"{selectedPerson.Name} is {dayDifference} days older than {people[i].Name}.");
                }
                else
                {
                    int ageDifference = selectedPerson.CalculateAgeDifference(people[i].BirthDate);

                    ageDifference = Math.Abs(ageDifference);
                    Console.WriteLine($"{selectedPerson.Name} is {ageDifference} days younger than {people[i].Name}.");
                }
               
            }

            Console.ReadLine();
        }
    }


}


