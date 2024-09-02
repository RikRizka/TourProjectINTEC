using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInHeritance
{
    public interface IMotorVoertuig: IVoertuig //Heritance
    {
        void Tanken();
    }
}
