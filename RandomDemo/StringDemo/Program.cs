using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SPLIT Methode

            // string greetings = "hello";
            // string result = string.Concat("hello", "world", "welcome");
            // Console.WriteLine(result);
            // Console.WriteLine(greetings.ToUpper());
            // Console.WriteLine(greetings.ToLower());
            // string getrimd = "                  Hello world                 ".Trim();
            // Console.WriteLine(getrimd);
            // int positie = "hello world".IndexOf("world");
            // Console.WriteLine(positie);
            //// int laatspositie = "Hello world world".LastIndexOf.("world");
            //// Console.WriteLine(laatspositie);
            // string[] worden = { "abc", "aaa", "zet row" };
            // string zin = string.Join(",", worden);
            #endregion
            string origineel = "Hello wereld";
            string vervangen = origineel.Replace("wereld", "rik");
            Console.WriteLine(vervangen);
            bool start = origineel.StartsWith("Hello");
            Console.WriteLine(start);
            bool ends = origineel.EndsWith("wereld");
            Console.WriteLine(ends);

            string leeg =null;
            bool isleeg = string.IsNullOrEmpty(leeg);
            Console.WriteLine(isleeg);

            string myString = "Hello world";
            string nieuw = myString.Insert(6, "wereld");
            Console.WriteLine(nieuw);

            string zin = "hello dit is een voobeeld zin";
            //string deelZin = zin.Substring(7,  zin.Length); //kalau baca semuanya 7, -7
            string deelZin = zin.Substring(7, 10);
            Console.WriteLine(deelZin); 

        }
    }
}
