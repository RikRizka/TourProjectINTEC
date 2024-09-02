using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningStruct
{
    public struct Auto
    {
        public string Merk;
        public string Model;
        public int Jaar;
         
        public Auto (string merk, string model , int jaar)
        {
            Merk = merk;
            Model = model;  
            Jaar = jaar;    
        }
        public override string ToString()
        {
            return $"Merk: {Merk} Model: {Model} Jaar: {Jaar}";
        }
    }
    
}
