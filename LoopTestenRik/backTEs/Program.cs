using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backTEs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region cobaan 1
            Console.WriteLine("Masukan kata, kata yang kamu mau.!");
            string kata = Console.ReadLine();

            int jumlahKalimat = 0;
            string[] remover = new string[] { ", ", ". ", " ", "/", "!", "?" };
            string[] removeSpasi = kata.Split(remover, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in removeSpasi)
            {
                jumlahKalimat++;
            }
            Console.WriteLine(jumlahKalimat);

            #endregion

            Console.WriteLine("Enter kalimat");
            string kalimat = Console.ReadLine();

            int kataKata = 0;

            string[] hapus = kalimat.Split(' ');

            foreach (string s in hapus) 
            {
                kataKata++;
            }
            Console.WriteLine(kataKata);    


        }
    }
}
