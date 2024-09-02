using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            Calculate(2, 3, "Rik");
            CalculateAge("Rik", 1993);
            int[] ints = { 110, -2, 3, 9 };
            InputArray(ints);

            //sum(1, 5, 9, 6, 900); // Gebruik met Params kalau bukan array
           // Sum(ints);
           int result = Sum(ints); // dari Sum di atas bisa juga menggunakan ini
            Console.WriteLine("Sum: " + Sum(result)); // sum jika di atas di gunakan
        }

        static void CalculateAge(string name, int yearBorn)
        {
            int age = 2023 - yearBorn;
            Console.WriteLine($"{name} you are {age} years old");
        }
        static void sayHello()
        {

            Console.WriteLine("Hello World");
        }
        static void Calculate(int x, int y, string name)
        {
            int z = x + y;
            Console.WriteLine(z + " " + name);
        }
        static void InputArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        static int Sum(params int[] numbers) //jika mau menggunakan array params nya id hilangankan
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum = sum + i;
            }
            return sum;
            //Console.WriteLine("sum: " + sum);
        }
    }
}
