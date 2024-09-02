using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherRefMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            ChangeNumber(number);
            Console.WriteLine("normal method " + number);

            ChangeNumber(ref number);
            Console.WriteLine("ref method" + number);
        }
        static void ChangeNumber(int number)
        {
            number = 20;
        }
        static void ChangeNumber(ref int number)
        {
            number = 50;
        }
    }
}
