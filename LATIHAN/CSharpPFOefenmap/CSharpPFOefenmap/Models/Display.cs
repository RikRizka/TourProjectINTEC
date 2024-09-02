using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap.Models
{
    public class Display:Rekening
    {
        public Display(string rekeningNumer, double saldo, DateTime createdatum):base (rekeningNumer, saldo, createdatum)
        {
            RekeningNumer = rekeningNumer;
            Saldo = saldo;
            Createdatum = createdatum;
        }
      
        public override string Dispay()
        {
            return $"your rekeneinng number {RekeningNumer} Your Saldo is {Saldo} Create datum is {Createdatum}";
        }

    }
}
