using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OeveningLooping2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            int numbers = 15;
           
            Console.WriteLine("The result from 1+2+3+4+5 is: ");
            for (int i = 1; i <= numbers; i+=2)

            {
                Console.WriteLine(i);
               
            }


        }
    }
}
