using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Dit is een zin");
            //stringBuilder.Append(" ");
            //stringBuilder.Append("Dit is een andre zin");
            //Console.WriteLine(stringBuilder);
            ////string zin1 = "Dit is een zin";
            ////string zin2 = "Dit is een andre zin";
            ////Console.WriteLine(zin1 + " " + zin2);
            StringBuilder sB = new StringBuilder();
            sB.Append("hello, ");
            sB.Append("wereld ");
            sB.Insert(6, "Lieave");
            sB.Remove(5, 4);
            Console.WriteLine(sB.ToString());


        }
    }
}
