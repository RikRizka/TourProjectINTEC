using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //minta pengguna memasukan usia mereka
            //jika usia > 18thn tampikan dewasa.
            //jika tidak tampilakn di bwah umur

            Console.Write("Entre your age :");
            int age = int.Parse(Console.ReadLine());  
            
            if (age > 18) 
            {
                Console.WriteLine("\nYou are adult");
            }
            else
            {
                Console.WriteLine("\nyou are too young ma boy");
            }
        }

    }
}
