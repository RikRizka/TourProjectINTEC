using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("int min. value \t " + int.MinValue);
            //Console.WriteLine("int max. value " + int.MaxValue + "\n");

            //Console.WriteLine("double min value " + double.MinValue);
            //Console.WriteLine("double max value " + double.MaxValue + "\n");

            //Console.WriteLine("byte min value " + byte.MinValue);
            //Console.WriteLine("byte max value " + Byte.MaxValue + "\n");

            //string name = "intec brussels  13, 100 bxl";
            //Console.WriteLine("the length of the name variabel is : " + name.Length);

            //Console.ReadLine();

            int btw;

            string btwAsString = "21";
            btw = int.Parse(btwAsString);

            Console.WriteLine(btw);

        }
    }
}
