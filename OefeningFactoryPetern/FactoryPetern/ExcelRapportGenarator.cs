using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPetern
{
    internal class ExcelRapportGenarator : IRapportGenerator
    {
        public void GenereerRaport()
        {
            Console.WriteLine("Exel raport generator");
        }
    }
}
