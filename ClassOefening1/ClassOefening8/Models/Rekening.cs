using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening8.Models
{
    public class Rekening
    {
        public double Saldo;

        public Rekening()
        {
            Saldo = 100;
        }
        public override string ToString()
        {
            return $"Saldo {Saldo}";
        }
    }
}
