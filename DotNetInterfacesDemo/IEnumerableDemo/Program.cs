using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            foreach(Car c in garage)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
