using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPetern
{
    internal class PdfRaportGenerator : IRapportGenerator
    {
        public void GenereerRaport()
        {
            Console.WriteLine("Ready to use PDF");
        }
    }
}
