using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OEFENING 1 === \n==================\n");

            Console.Write("Give me a sentence: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("\nResult!");

            int counting = LeterCountWithoudSPace(userInput);
            Console.WriteLine($"==>Your sentence  has a totals of {counting}");

            int counting2 = LetterCountWithSpace(userInput);
            Console.WriteLine($"==>Your sentence  has a totals of {counting2}");

            //List<RRR> list = new List<RRR>();
            
            RRR rrr = new RRR();
            rrr.GetWords(userInput);
            
           // Console.WriteLine($"==>your words {list.Count}");

        }
        public static int LeterCountWithoudSPace(string userInput)
        {
            int count = 0;
            foreach (char item in userInput)
            {

                if (item != ' ')
                {
                    count++;
                }
            }
            return count;
        }
        public static int LetterCountWithSpace(string userInput)
        {
            int count = 0;
            foreach (char item in userInput)
            {

                if (char.IsLetterOrDigit(item))
                {
                    count++;
                }
                else if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        


    }
}
