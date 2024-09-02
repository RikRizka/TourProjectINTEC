using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekening rekening = new Rekening("123-456789-01");
            rekening.VoerTransactieUit(5000.00m, "Storting");
            rekening.VoerTransactieUit(-300.00m, "Geld opnamen");
            rekening.VoerTransactieUit(-800.00m, "Geld opnamen");
            rekening.VoerTransactieUit(-200.00m, "Geld opnamen");


            Console.WriteLine("Historiek van de transacties");
            rekening.TooTransacties();
            
        }
    }
}
