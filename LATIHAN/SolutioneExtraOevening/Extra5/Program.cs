using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Minta pengguna memasukan name meraka itu John jika bukan nama tidak di kenal

            string Name;
            Console.Write("Enter your name :");
            Name = Console.ReadLine();
            if (Name == "John") 
            {
                Console.WriteLine("Welcome John!");
            }
            else 
            {
                Console.WriteLine("You are not John!");
            }        
        }

    }
}
