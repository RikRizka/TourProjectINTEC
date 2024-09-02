using ClassLibraryOne;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow world from Console Main");
            Services services = new Services();
            services.DoSomething();
            Console.ReadLine();
            Person p = new Person();
        }
    }
}       
