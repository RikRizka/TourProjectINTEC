using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemeenschapCL.Models
{
    public class Docent
    {
        public int DocentNr { get; set; }
        public  string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public string Wedde { get; set; }
        public string CampusNr { get; set; }

        public override string ToString()
        {
            return $" {DocentNr} {Voornaam} {Familienaam} {Wedde}";
        }

    }
}
