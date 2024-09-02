using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace VoegWordenSamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Rick";
            string lastName = "Usman";
            string combineerDeName = VeogWordenSamen(firstName , lastName);
            Console.WriteLine(combineerDeName);
            Console.ReadLine();
        }
        static string VeogWordenSamen(string firstName, string lastName)
        {
            string combineerDeName = firstName + lastName;
            return combineerDeName;
        }
    }
}

