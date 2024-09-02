using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ManualyCopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        //    int[] intLeft = { 100, 600, 90, 42, 555, 666, 888 };
        //    int[] intRight = { 9, 8, 10, 2, 5, 6, 8 };
        //    int[] temp = new int[intLeft.Length];

        //    for (int i = 0; i < intLeft.Length; i++)
        //    {
        //        temp[i] = intLeft[i];
        //    }

        //    Console.WriteLine("Int left Array;");
        //    for (int i = 0; i < intLeft.Length; i++)
        //    {
        //        intLeft[i] = intRight[i];
        //        Console.Write(intLeft[i] + " ");


        //    }
        //    Console.WriteLine();

        //    Console.WriteLine("Int right Array;");

        //    for (int i = 0; i < intRight.Length; i++)
        //    {
        //        intRight[i] = temp[i];
        //        Console.Write(intRight[i] + " ");
        //    }
        //    string line = new string('_', 40);

            //for (int i = 0; i < length; i++)
            //{

            //}

            //Console.WriteLine(line);
            //Console.WriteLine("Right");
            //for (int i = 0; i < intRight.Length; i++)
            //{
            //    Console.WriteLine(intRight[i]);
            //}
            //Console.WriteLine(line);
            //Console.WriteLine("left");
            //for (int i = 0; i < intLeft.Length; i++)
            //{
            //    Console.WriteLine(intLeft[i]);
            ////}
            //Console.ReadLine();

            int[] array1 = { 100, 600, 200, 400, 40 };
            int[] array2 = { 9, 8, 5, 6, 3 };
            int[] kosong = new int[array1.Length];

            for (int i = 0;i < array1.Length; i++)
            {
                kosong[i] = array1[i];
            }
            Console.WriteLine("kiri");
            Console.WriteLine("-----------------");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array2[i];
                Console.WriteLine($" Array Kiri {array1[i]}");
            }
            Console.WriteLine("\nKanan");
            Console.WriteLine("------------------");
            for (int i = 0;i < array2.Length ; i++)
            {
                array2[i] = kosong[i];
                Console.WriteLine($"Array kanan {array2[i]}");
            }

        }
    }
}
