using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Auto : Voerthuig
    {
        public override void Start()
        {
            Console.WriteLine("Auto is gestart");
        }
    }
}
