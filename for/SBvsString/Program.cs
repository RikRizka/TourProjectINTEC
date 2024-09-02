using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBvsString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String builder is good to use because cepat
            Stopwatch stopwatch = new Stopwatch();

            string tekst = "hello";
            for (int i = 0; i < 100000; i++)
            {
                tekst += "world";
            }
            stopwatch.Stop();
            Console.WriteLine("With string" + stopwatch.ElapsedMilliseconds);
            /////////////////////////////////////////////////////////////////
            stopwatch.Restart();

            StringBuilder sb = new StringBuilder();      
            for (int i = 0; i < 100000; i++)
            {
               sb.Append(" Wereld");
            }
            stopwatch.Stop();
            Console.WriteLine("With stringbuilder "+ stopwatch.ElapsedMilliseconds);


        }
    }
}
