using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] intigers = { 99, 80, -3, 14, 55 };
            int minVallue = intigers[0];
            //for (int i = 0; i < intigers.Length; i++) ;
            int sum = 0;
            int mid = (intigers.Length - 1) / 2;
            for (int i = mid; i < intigers.Length; i++)
            {
                if (intigers[i] < int.MinValue)
                {
                    //minVallue = intigers[i];
                }
                sum += intigers[i];
                //Console.WriteLine(intigers[i]);
                if (intigers[i] % 2 == 1) ;
            }
            //Console.WriteLine($"The min is {minVallue}");
            Console.WriteLine($"The min is {sum}");
            //Console.WriteLine($"The min is {intigers.Sum()}");
            //Console.ReadLine();

            foreach (var item in intigers)
            {
                //intigers[element] = minVallue; // tidak bisa di ganti
               
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

    }
}
