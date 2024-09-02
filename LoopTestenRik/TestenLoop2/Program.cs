using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestenLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jumlahKata = 0;
            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine();
            string [] symbol = new string[] { " . ", " " };
            string[] remove = sentence.Split( symbol, StringSplitOptions.RemoveEmptyEntries );    
             foreach (string s in remove) 
            {
                jumlahKata++;
            }
            Console.WriteLine(jumlahKata);





            //Console.Write("voer een zin in: ");
            //string zin = Console.ReadLine().ToLower();

            //foreach (char i in zin)
            //{
            //    if
            //}
        }
    }
}
