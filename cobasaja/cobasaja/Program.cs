using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cobasaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("masukan beberapa kalimat");
            string kalimat = Console.ReadLine();
           
            string[] hapus = kalimat.Split(' ');

            foreach (string c in hapus)
            {
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
