using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap.Models
{
    public class Rekening
    {
        public string RekeningNumer { get; set; }
        public double Saldo { get; set; }
        public DateTime Createdatum { get; set; }

        public Rekening(string rekeningNumer, double saldo, DateTime createdatum)
        {
            RekeningNumer = rekeningNumer; 
            Saldo = saldo;
            Createdatum = createdatum;
        }
        public void Setor(double bedrag)
        {
            Saldo += bedrag;
        }
        public virtual string Dispay()
        {
            return $"your rekeneinng number {RekeningNumer} Your Saldo is {Saldo} Create datum is {Createdatum}";
        }

        // public void double
    }
}
