using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Result
            Console.WriteLine("Enter your age please ");
            int result = 0;
            int.TryParse(Console.ReadLine(), out result);
            if (result == 0)
            {
                Console.WriteLine("Wrong input");

            }
            else
            {
                Console.WriteLine("result " + result);
            }
            #endregion

           // int age = 0;


           // Console.WriteLine("give the age in please");
           //bool isGelukt = int.TryParse(Console.ReadLine(), out age);   
           // if (isGelukt) 
           // {
           //     Console.WriteLine($"The age is {age}");
           // }
           // else
           // {
           //     Console.WriteLine("Problem");
           // }
        }

    }
}
