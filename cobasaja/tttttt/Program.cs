using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tttttt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int jumlahKalimat = 0;
            Console.WriteLine("Masukan beberapa kalimat");
            string kalimat = Console.ReadLine();

            string[] remove = kalimat.Split(' ');
             foreach (string s in remove)
            {
                jumlahKalimat++;
            }
            Console.WriteLine(jumlahKalimat);
        }
    }
}
