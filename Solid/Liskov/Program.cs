using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List contitution sprinsipse
            Voerthuig voerthuig = new Voerthuig();
            Auto auto = new Auto();

            Test test = new Test();
            test.StartVoerthuig(voerthuig);   
            test.StartVoerthuig(auto);

        }
    }
}
