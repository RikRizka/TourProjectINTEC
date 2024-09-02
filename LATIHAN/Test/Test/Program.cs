using System;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("mijn naam is : ");
            string naam = Console.ReadLine();
            //Prosses
            string calling = "het is mijn naam " + naam;
            //output
            Console.WriteLine(calling);
            Console.ReadLine(); 
        }
    }
}
