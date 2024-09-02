using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReturnDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Rik";
            int yearBorn = 1993;
            int age = CalculateAge(yearBorn); // CalculateAge di sini adalah Methode
            Console.WriteLine($"{name} you are {age} years old"); // di age nya disa ju

            string firstName = "Rick";
            string surName = "Usman";
            string result = ConcatName(firstName, surName); //Goed om te gebruiken
            Console.WriteLine(result);

            Console.WriteLine(ConcatName(name, surName)); // ini hanya di gunakan hanya untuk enkel (tidak bagus)

            Console.WriteLine(GetLength(result));
        }
        static int CalculateAge(int yearBorn)
        {
            int age = 2023 - yearBorn;
            return age;
        }
        static string ConcatName(string firstName, string sureName)
        {
            return $" {firstName} {sureName}";
        }
        static int GetLength(string name)
        {
            return name.Length; 
        }
        

    }
}
