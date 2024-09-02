using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //Console.Write("Please enter age :");
            //age = int.Parse(Console.ReadLine());
            //if (age > 40)
            //{
            //    Console.WriteLine("sorry u mag niet binnen!");

            //}
            //else if (age < 19 ) 
            //{
            //    Console.WriteLine("je bent jong");
            //}
            //else
            //{
            //    Console.WriteLine("welcome");

            int age;
            Console.Write("Please enter age :");
            age = int.Parse(Console.ReadLine());
            if (age > 40)
            {
                Console.WriteLine("sorry u mag niet binnen!");

            }
            else if (age > 29 && age < 36)
            {
                if (age == 33)
                {
                    Console.WriteLine("je bent VIP");
                    Console.ReadLine();
                    return;

                }

                Console.WriteLine("ge bent super welcome");
            }
            else if (age < 19)
            {
                Console.WriteLine("je bent jong");
            }
            else
            {
                Console.WriteLine("welcome");

            }
        }
    }
}
