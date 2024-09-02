using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CheckFB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int userinput = Int32.Parse(Console.ReadLine());
            int result = userinput +15 *2 -4 /2 ;
            int difference = userinput - result;
            Console.WriteLine("The result is:" + result);
            Console.WriteLine("Difference is:" + difference);
        }
    }
}
