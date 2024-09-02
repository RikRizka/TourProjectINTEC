using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] maanden = new string[] { "januari", "februari", "maart", "aprill", "mei", "juni", 
            "juli", "augustus", "september", "oktober", "november", "december" };
            // 
            string[] kopie = new string[maanden.Length + 1];
            //Array.Resize(ref maanden, maanden.Length + 2); 
            //maanden[12] = "13maand";
            //maanden[13] = "14 maand";
           // Array.Resize(ref maanden, maanden.Length + 1);
            int count = maanden.Length;
            //string lijn = new string('-', 50);
            //Console.WriteLine(lijn);
            //string showArray = string.Join("-", maanden);
            //Console.WriteLine(showArray); 
            //foreach (string s in maanden)
            //{ // if (s.IndexOf ==maanden.Length-1 )
            // { //
            //Console.WriteLine(s + " ,");



        }
    }
}
