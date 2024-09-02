using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExtra
{
    public class DemoClass : IinterfaceA, IinterfaceB //Explicit
    {
        void IinterfaceA.DoeIets()
        {
            Console.WriteLine("Doeits meth0de via IinterfaceA");
        }
        void IinterfaceB.DoeIets()
        {
            Console.WriteLine("Doeits meth0de via IinterfaceB");
        }

    }
}
