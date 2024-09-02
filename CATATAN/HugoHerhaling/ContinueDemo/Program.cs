using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i<10) 
            {
                //i++; 
                if (i == 4)
                {
                    //Console.WriteLine("Rik");
                    continue; //empat akan heilang
                    
                }
                //i++;
                Console.WriteLine(i);

            }
            Console.WriteLine("and of loop");
        }
    }
}
