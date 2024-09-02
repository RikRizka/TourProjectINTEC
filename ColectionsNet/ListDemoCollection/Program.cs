using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemoCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = 25;
            //object obj = x; // Boxing
            //double y = (double)obj;// Unboxing

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //list.Remove(20);
            Console.WriteLine("After removing 20");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Add(50);
            list.Add(60);
            list.Add(70);
            list.Add(80);
            list.Add(90);
            list.Add(100);
            Console.WriteLine("Count " + list.Count);
            Console.WriteLine("Capaciteit " + list.Capacity);

            Console.WriteLine(list[2]);
            if (list.Contains(30))
            {
                Console.WriteLine("Found 30");
            }
            else
            {
                Console.WriteLine("Not Found 30");
            }
            list.AddRange(new int[] { 201, 301, 400,500 });
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            int[] arr = list.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
           // int evenGetal = list.Find(x => x % 2 == 1);
            Console.WriteLine("Even getalen");
            foreach (var item in list.FindAll(x => x % 2 == 0))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("string join");

            string listString = string.Join(",", list);
            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 70)
                {
                    list[i] = 700;
                }
            }
           
            list.Insert(2, 999);
            Console.WriteLine("----------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
