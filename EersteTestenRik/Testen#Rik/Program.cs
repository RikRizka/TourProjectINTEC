using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testen_Rik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal decimalNum = 10.3m;
            double doubleNum = 2.12;
            int intNum = 15;
            byte num = 225;
            string myName = "Rik";
            bool check = true;

            Console.WriteLine("Decimal number is " +decimalNum);
            Console.WriteLine("Double number is " +doubleNum);
            Console.WriteLine("Int number is " +intNum);
            Console.WriteLine("My name is " +myName);
            Console.WriteLine(check);
            Console.ReadLine();
        }
    }
}
