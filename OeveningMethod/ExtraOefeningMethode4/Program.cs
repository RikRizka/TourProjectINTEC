using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningMethode4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 1, 5, 2, 1 };
            Console.Write("Enter a number 1 - 5: ");
            int target = int.Parse(Console.ReadLine());
            int result = HitungKejadian(array, target);
            Console.WriteLine($"target angka adalah {target} dengan jumlah {result}");
        }
        static int HitungKejadian(int[] array, int target)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number == target) 
                { 
                count++;
                }             
            }
            return count;
        }
    }
}
