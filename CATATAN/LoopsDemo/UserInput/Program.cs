using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNr = 0;
            int secondNr = 0;
              int sum;
            string lanjut = "y";
          
            while (lanjut.ToLower() == "y")
            {
                Console.Clear();
                Console.Write("Enter first no :");
                firstNr = int.Parse(Console.ReadLine());

                Console.Write("Enter second no :");
                secondNr = int.Parse(Console.ReadLine());

                sum = firstNr + secondNr;
                Console.WriteLine(sum);
                Console.WriteLine("continue ? y/n");
                lanjut = Console.ReadLine();
                //Console.ReadLine();
            }
        }
    }
}
