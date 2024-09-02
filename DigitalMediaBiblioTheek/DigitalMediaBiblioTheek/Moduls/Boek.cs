using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMediaBiblioTheek.Moduls
{
    public class Boek : IBoek
    {
        private string _boekTitle { get; set; }
        public Boek(string boekTitle)
        {
            _boekTitle = boekTitle;
        }
        public void Lees()
        {
            Console.WriteLine($"read from {_boekTitle}");
        }
        public void ToonDetails()
        {
            Console.WriteLine($"Show details {_boekTitle}");
        }

    }
}
