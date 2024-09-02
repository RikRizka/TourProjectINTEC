using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningMethode3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka1 = 512; // di simpan ke digitTerakhir1
            int angka2 = 25; // di smpan ke digitTerakhir2
            
            string digitTerakhir1 = AmbilDigitTerakhir(angka1); // angka1 akan di simpan di digitTerakhir1
            string digitTerakhir2 = AmbilDigitTerakhir(angka2);

            Console.WriteLine($"{angka1} \" {digitTerakhir1} \" ");
            Console.WriteLine($"{angka2} \" {digitTerakhir2} \" ");
            Console.ReadLine();
        }
        static string AmbilDigitTerakhir(int angka) // angka parameter
        {
          ////  if (angka <= 0)
          //  {
          //      Console.WriteLine("bilangan harus positif");
          //  }
          ////pada Method ini yang benar2 mengambil angka terakhir
            string angkaString = angka.ToString(); // mengubah angka 1 dan 2 ke string dari 512 ke "512"
            char digitTerakhir = angkaString[angkaString.Length -1]; // mengambil karakter terakhir

            return digitTerakhir.ToString();
          
        }
       
    }


}
    

