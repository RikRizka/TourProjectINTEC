using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Give me a number");
            //    string invoer = Console.ReadLine();
            //    //int result;
            //    //if (int.TryParse(invoer, out result)) 
            //    //{
            //    //    Console.WriteLine(result);
            //    //}
            //    //else 
            //    //{
            //    //    Console.WriteLine("verkende inout");
            //    //}    

            string invoer = Console.ReadLine();
            int result = 0;
            bool isGelukt = int.TryParse(invoer, out result);

            if (isGelukt)
            {
                Console.WriteLine(result);
            }
            else 
            {
               Console.WriteLine("verkeerde input");
            }
            
            
        }
    }
}
