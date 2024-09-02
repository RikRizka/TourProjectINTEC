using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeerWoordOm
{
    internal class Program
    {
        static void Main(string[] args)
        // Hello terbalik menjadi olleH
        {
            string sayHi = "Hello";
            string reverse = KeerWordOm(sayHi);
            Console.WriteLine(reverse);
        }
        static string KeerWordOm(string sayHi)
        {
            char[] reverse = sayHi.ToCharArray();
            Array.Reverse(reverse); //yang membalikan kata
            return new string(reverse);
        }
    }
}
