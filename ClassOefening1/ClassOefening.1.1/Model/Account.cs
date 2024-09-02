using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening._1._1.Model
{
    internal class Account
    {
        public string RekeningNumer { get; set; }
        public double Saldo { get; set; }
        public DateTime dateTimes { get; set; } 

        public Account(string rekeningNumer, double saldo)
        {
            RekeningNumer = rekeningNumer;
            Saldo = saldo;
           DateTime dateTimes = DateTime.Now;
        }
        public void Afbeelden()
        {
            Console.WriteLine($"Rekening No : {RekeningNumer} Saldo: {Saldo} Year: {dateTimes} "); ;
        }
        public void Deposite (double amount ) 
        { 
        Saldo += amount;
        }
    }
}
