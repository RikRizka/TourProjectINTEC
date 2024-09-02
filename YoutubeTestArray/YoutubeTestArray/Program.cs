
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeTestArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namaStudent = new string[4];

            //Console.Write("How many students: ");
            //Console.ReadLine();

            Console.WriteLine("Enter nama student: ");
            
           

            for (int i = 0; i < namaStudent.Length; i++)
            {
                namaStudent[i] = Console.ReadLine().ToLower(); w
               
            }
            Console.WriteLine("_________________");
            Array.Sort(namaStudent);

            for (int i = 0; i < namaStudent.Length; i++)
            {

                Console.WriteLine(namaStudent[i]);              
            }
            Console.ReadLine();
            

        }
    }
}
