using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class MultyFuntionDevice : IMultyfuntionDevice
    {
        public void Fax()
        {
            // Console.WriteLine("Faxing from multyFantionDevice");
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Printing from multyFantionDevice");
        }

        public void Scan()
        {
            //Console.WriteLine("Scaning from multyFantionDevice");
            throw new NotImplementedException();
        }
    }
}
