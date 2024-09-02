using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrintAlfabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            //{
            //    Console.WriteLine(alphabet);
            //}
            //Console.WriteLine("--------------------------------");
            //for (int i = 0; i < 26; i++)
            //{
            //    Console.WriteLine(Convert.ToChar(i+ (int) 'A'));
            //}
            char letterA = 'a';
            if (char.IsLetter(letterA))
            {
                Console.WriteLine("This is an letter");
            }
            else if (char.IsLetter(letterA)) 
            {
                Console.WriteLine("this is a digic");
            }
            else
            {
                Console.WriteLine("this is not a digit letter");
            }
           
        }
    }
}
