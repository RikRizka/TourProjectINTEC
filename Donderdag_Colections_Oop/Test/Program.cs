using Dagboek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda1 = new Agenda();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Welcome!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today is: " + DateTime.Now);
                Console.ResetColor();



                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("\nToday input MM/dd/yyyy");
                int userData1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Tomorrow Input MM/dd/yyyy");
                int userData2 = int.Parse(Console.ReadLine());
            }
           

            //DateTime parsDate = DateTime.Parse(userDate);

            Console.WriteLine("Enter something");
            string usertxt = Console.ReadLine();

            Agenda agenda = new Agenda();
            // agenda.AddInput();
        }
    }
}
