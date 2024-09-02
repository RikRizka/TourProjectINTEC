using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEvenGetal6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            bool hasil = IsEvenGetal(num);
            Console.WriteLine(hasil);
            Console.ReadLine();
        }
       public static bool IsEvenGetal (int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
