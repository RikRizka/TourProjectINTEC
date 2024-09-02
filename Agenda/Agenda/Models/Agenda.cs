using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
    enum Daggen
    {
        Mandag,
        Dinsdag,
        Woendsdag,
        Donderdag,
        Frijdag,
        Zaterdag,
        Zondag,
    }
    class Agenda
    {
        public string Description { get; set; }
        public Daggen Daag { get; set; }
        public int Uuren { get; set; }
        public Agenda(string description, Daggen daag, int uuren)
        {
            Description = description;

            Uuren = uuren;


        }
    }

}
