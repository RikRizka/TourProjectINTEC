using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesControle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.Write("enter your name: ");
            p.Name = Console.ReadLine();           
         

            Console.Write("Enter your age: ");
            p.Leeftijd = int.Parse(Console.ReadLine());
            

            Console.ReadLine();
        }
    }
}
