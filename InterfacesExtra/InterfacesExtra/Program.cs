using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass();
            IinterfaceA a = demo;
            a.DoeIets();

            IinterfaceB b = demo;
            b.DoeIets();

        }
    }
}
