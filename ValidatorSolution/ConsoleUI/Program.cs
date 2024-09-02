using LibraryValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test if is number");
            string inputIsnumber = Console.ReadLine();
            bool result = Validator.IsNumber(inputIsnumber);
            Console.WriteLine(result);
            

            Console.WriteLine("Test if intigeer");
            string inputIsInteger = Console.ReadLine();
            bool resultISIntiger = Validator.IsInteger(inputIsInteger);
            if (!resultISIntiger)
            {
                Console.WriteLine("This is not valid Integer");
            }
            Console.WriteLine(resultISIntiger);



            Console.WriteLine("Test if not Empty");
            string inputEmpty = Console.ReadLine();
            bool resultIsEmpty = Validator.IsNotEmpty(inputEmpty);
            Console.WriteLine(resultIsEmpty);

            Console.WriteLine("Test if Negetive");
            string inputPosiveNum = Console.ReadLine();
            bool resultPositiveNum = Validator.IsNotPositive(inputPosiveNum);
            Console.WriteLine(resultPositiveNum);

            Console.WriteLine("Test between number 20 and 100");
            String inputTusen20en100 = Console.ReadLine();
            bool sesultIs = Validator.IsBetween(inputTusen20en100);
            Console.WriteLine(sesultIs);

        }
        
        
    }
}
