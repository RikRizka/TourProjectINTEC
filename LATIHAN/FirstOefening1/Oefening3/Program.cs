using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            int kwadraad2;
            int kwadraad3;
            
            Console.Write("Enter a number :");
            userNumber = Int32.Parse(Console.ReadLine());
            
            kwadraad2 = userNumber * userNumber;
            kwadraad3 = userNumber * userNumber * userNumber;

            Console.WriteLine($"Squared {userNumber} is :");
            Console.WriteLine($"{kwadraad2} and {kwadraad3}");
            Console.ReadLine();

            #region Kanan's
            Console.WriteLine("Geef een getal in: ");
            string input = Console.ReadLine();
            int getal = Int32.Parse(input);

            Console.WriteLine("Het kwadraat is: {0}", getal * getal);
            Console.WriteLine("De derde macht is: {0}", getal * getal * getal);

            Console.ReadKey();
            #endregion
        }


    
    }
}
