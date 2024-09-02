using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening7.Models
{
    public class Auto
    {
        public string Merk;
        public string Model;
        public int Jaar;
        public Auto(string Merk, string Model, int Jaar)
        {
            this.Merk = Merk;
            this.Model = Model;
            this.Jaar = Jaar;

        }
        public override string ToString()
        {
            return $"Merk:{Merk} Model:{Model} Jaar:{Jaar}";
        }
    }
}
