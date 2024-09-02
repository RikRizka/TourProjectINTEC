using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "what ever text;;; :--for ** learning // * c sharp";
            string[] separators = new string[] { ";", ":", "-", "/", "*", " " };
            string[] resul = tekst.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in resul)
            {
                Console.WriteLine(s);
            }

        }
    }
}
