using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //minta pemgguna memasukan angak apakah itu positif atau negatif atau 0
            Console.Write("Enter a nunber :");
            int numb = int.Parse(Console.ReadLine());   
             if (numb > 0) 
            {
                Console.WriteLine("this number is positive");
            }
             else if (numb < 0) 
            {
                Console.WriteLine("this number is negative");
            }
             else 
            {
                Console.WriteLine("this number is zero");
            }
        }
    }
}
