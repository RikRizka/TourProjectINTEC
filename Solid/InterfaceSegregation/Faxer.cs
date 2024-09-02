using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Faxer : IFax
    {
        public void Fax()
        {
            Console.WriteLine();
        }
    }
}
