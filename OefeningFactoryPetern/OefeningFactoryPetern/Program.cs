using FactoryPetern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningFactoryPetern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGeneratoFactory factory = new ReportGeneratoFactory();

            IRapportGenerator rapportGenerator = factory.GetRapportGenerator("PDF");
            rapportGenerator.Gene();

            rapportGenerator = factory.GetRapportGenerator("Exel");
            rapportGenerator.GenereerRaport();

            rapportGenerator = factory.GetRapportGenerator("Word");
            rapportGenerator.GenereerRaport();


        }
    }
}
