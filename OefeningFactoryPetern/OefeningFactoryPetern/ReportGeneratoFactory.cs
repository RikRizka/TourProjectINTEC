using FactoryPetern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningFactoryPetern
{
    public class ReportGeneratoFactory
    {
        public IRapportGenerator GetRapportGenerator(string type)
        {
            switch (type) 
            {
                case "PDF":
                    return new PdfRapportGenerator();
                case "Exel":
                    return new ExelRapportGenarator();
                case "Word":
                    return new WordRapportGenerator();
                default:
                    throw new ArgumentException("Ongeldig rapport");
            }
        }

        private class PdfRapportGenerator : IRapportGenerator
        {
        }

        private class ExelRapportGenarator : IRapportGenerator
        {
        }
    }

    internal class WordRapportGenerator : IRapportGenerator
    {
    }
}
