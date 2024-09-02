using DigitalMediaBiblioTheek.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMediaBiblioTheek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Boek boek = new Boek("bjv");
            boek.Lees();
        }
    }
}
