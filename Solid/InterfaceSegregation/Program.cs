using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Implementasi
            //MultyFuntionDevice multyFuntionDevice = new MultyFuntionDevice();
            //multyFuntionDevice.Print();
            //multyFuntionDevice.Scan();
            //multyFuntionDevice.Fax();

            //Printer print = new Printer();
            //print.Print();

            //Scanner scanner = new Scanner();
            //scanner.Scan();

            //Faxer faxer = new Faxer();
            //faxer.Fax();

            AllPosible posible = new AllPosible();
            posible.Fax();
            posible.Print();
            posible.Scan();
        }

    }
}
