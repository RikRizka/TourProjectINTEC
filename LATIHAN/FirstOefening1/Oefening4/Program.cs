using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstUserNumber;
            int secondUserNumber;
            int resultPlus;
            int theDifferent;
            int resultMultiplay;
            int devide;


            Console.Write("Enter first number :");
            firstUserNumber = int.Parse(Console.ReadLine());

            Console.Write("enter second number :");
            secondUserNumber = int.Parse(Console.ReadLine());
            
            resultPlus = firstUserNumber + secondUserNumber;
            theDifferent = firstUserNumber - secondUserNumber;  
            resultMultiplay = firstUserNumber * secondUserNumber; 
            devide = firstUserNumber / secondUserNumber;

            Console.WriteLine("The result of plus is " + resultPlus);
            Console.WriteLine("different is " + theDifferent);
            Console.WriteLine("and multiplay is " + resultMultiplay);
            Console.WriteLine("and devide is " + devide);
            Console.ReadLine(); 


        }
    }
}
