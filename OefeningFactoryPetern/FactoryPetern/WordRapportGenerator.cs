using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPetern
{
    internal class WordRapportGenerator : IRapportGenerator
    {
        public void GenereerRaport()
        {
            Console.WriteLine("Ready MS");
        }
    }
}
