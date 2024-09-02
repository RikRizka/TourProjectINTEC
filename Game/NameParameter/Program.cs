using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Rik";
            int age = 30;
            double hight = 1.60;
            string address = "no name straat ";
            DisPlay(age:age, hight:hight, name:name, address:address);
        }
        static void DisPlay(string name, int age, double hight, string address) 
        {
            Console.WriteLine($"{name} {age} {hight} {address} ");
        }
    }
}
