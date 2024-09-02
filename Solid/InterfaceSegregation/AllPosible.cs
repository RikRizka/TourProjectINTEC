using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class AllPosible : IFax, IPrint, IScan
    {
        public void Fax()
        {
            Console.WriteLine("Faxing");
        }

        public void Print()
        {
            Console.WriteLine("Printing");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning");
        }
    }
}
