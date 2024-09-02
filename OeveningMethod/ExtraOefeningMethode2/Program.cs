using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningMethode2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method mebuat sebuah program yang meminta pengguna memasukan bialngan bulat
            // dan kemudian mencetak bilangan terbesar.
            Console.WriteLine("Enter 3 numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNum1 = GetMax(num1, num2);
            int maxNum2 = GetMax(maxNum1, num3);
            Console.WriteLine($"The bisggest number between: {num1} , {num2} and {num3} is {maxNum2}");
            Console.ReadLine();
        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
