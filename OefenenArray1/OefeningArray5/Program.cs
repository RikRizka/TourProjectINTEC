using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OefeningArray5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 15, 12, 0, 5, 9, -5, 66, 78, 9, 1 };
            int[] array2 = { 1, 45, 99, 84, 75, -5, 66, 78, 9, 1 };
            int[] array3 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] >= array2[i]) 
                {
                    array3[i] = array2[i];
                }
                int number = i+1;
                array3[i] = Math.Min(array1[i], array2[i]);
                Console.WriteLine($"{number} = {array3[i]}");
            }

        }
    }
}
