using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankApp
{
    public class Rekening
    {
        public string RekeningNumer { get; set; }
        public decimal Saldo { get; set; }
        private Transacie[] _transacies = new Transacie[100];      
        private int _aantalTransacie = 0;
        public Rekening(string rekeningNumer)
        {
            RekeningNumer = rekeningNumer;
        }
        public void VoerTransactieUit(decimal bedrag, string omschrijving)
        {
           
            _transacies[_aantalTransacie++] = new Transacie(bedrag, DateTime.Now, omschrijving);
            i++
            Saldo += bedrag;
            
        }
        public void TooTransacties()
        {
            for (int i = 0; i < _transacies.Length; i++)
            {
                if (_transacies[i] != null)
                    break;
            }
        }
        //public void TooTransacties()
        //{
        //    foreach (Transacie item in _transacies) //in array
        //    {
        //        if (item == null)
        //            break;
        //        Console.WriteLine($"{item.Datum} {item.Bedrag} {item.Omschrijving} saldo: {Saldo}");

        //    }
        //}

    }
}
