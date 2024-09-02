using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WithIntVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intLeft = { 100, 600, 90, 42, 555, 666, 888 };
            int[] intRight = { 9, 8, 10, 2, 5, 6, 8 };
            int empty;
            for (int i = 0; i < intLeft.Length; i++)
            {
                empty = intLeft[i];
                intLeft[i] = intRight[i];
                intRight[i] = empty;

            }
            
            foreach (int i in intLeft)

            {
                Console.WriteLine("right " + i);
            }
            string line = new string('_', 40);
            foreach (int i in intRight)
            {
                Console.WriteLine("Left " + i);
            }
            Console.ReadLine();
        }   
    }
}