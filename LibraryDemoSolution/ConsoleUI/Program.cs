using ClassLibraryDemo;
using ClassLibraryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is console program");
            //Services services = new Services();
            //var p = services.DoSomthing();
            //Console.WriteLine(p.FirstName + " " + p.LastName);
            //
            Person person = new Person();
            person.FirstName = "Rick";
            person.LastName = "usmn";
            person.DateOfBirth = new DateTime(1993, 10, 18);

            Services services = new Services();
            services.CalculateAge(person);
            Console.WriteLine(person.FirstName + " " + person.LastName + " is " + person.Age + " years old" );

            Console.WriteLine("--En age minus twee is--");

            //Services s = new Services();
            services.GetAgeMinTwee(person);
            Console.WriteLine(person.FirstName + " " + person.LastName + " is " + person.Age + " years old");



        }
    }
}
