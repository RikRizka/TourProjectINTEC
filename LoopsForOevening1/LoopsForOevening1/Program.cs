using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace LoopsForOevening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //masukan 10 angka dan jumlakan setelah jumlah semua hasil di bagi untuk rata2

            int numbers = 10;
            int sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                Console.Write("Enter a number " + i + " :");
                int user = int.Parse(Console.ReadLine());
                    sum += user;
            }
            int square = sum / numbers;
            Console.WriteLine($"the sum of 10 numbers is {sum}");
            Console.WriteLine($"The square numbers of 10 is {square}");
            
        }
        
    }

}
