using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // minta pemgguana memasukan angka yang berkelipatan 5 jika tidak bukan keliapatan 5

            Console.Write("Enter a number :");
            int num = int.Parse(Console.ReadLine());    

            if (num %5==0) 
            {
                Console.WriteLine("This number multiple of 5");
            }
            else
            {
                Console.WriteLine("This nuumber is not multiple of 5");
            }
        }
    }
}
