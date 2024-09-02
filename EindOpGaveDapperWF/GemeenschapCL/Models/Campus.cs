using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace GemeenschapCL.Models
{
    public class Campus
    {
        public int CampusNr { get; set; }
        public string Naam { get; set; }
        public string HuisNr { get; set; }
        public string PostCode { get; set; }
        public string Gemeente { get; set; }

        public override string ToString()
        {
            return $"{CampusNr} {Naam} {HuisNr} {Gemeente} ";
        }
    }
}
