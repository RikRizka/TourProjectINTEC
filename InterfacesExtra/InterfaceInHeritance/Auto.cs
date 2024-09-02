using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInHeritance
{
    public class Auto : IMotorVoertuig
    {
        public void Start()
        {
            Console.WriteLine("Start method");
        }

        public void Stop()
        {
            Console.WriteLine("Stop method");
        }

        public void Tanken()
        {
            Console.WriteLine("Tanken method");
        }
    }
}
