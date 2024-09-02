using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInHeritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Start();
            auto.Stop();
            auto.Tanken();
        }
    }
}
