using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraArrayOefeningen1._1
{
    internal class Program
    {
        static void Main(string[] args)
        //tulisla program C# yang menemukan elemen maksimum dan minimu
        {
            int[] number = { 2, 5, 7, 1, 9 };
            int min = number[0];
            int max = number[0];

            //int min = int.MaxValue;
            //int max = int.MinValue;
            for (int i = 1; i < number.Length; i++) 
            {
                if (number[i] < min)
                {
                    min = number[i];
                    Console.WriteLine("Minimal number is " + min);

                }
                else if (number[i]> max)
                {
                    max = number[i];
                    Console.WriteLine("max" + max);
                }
        
                
                
            }
            

        }
    }
}
