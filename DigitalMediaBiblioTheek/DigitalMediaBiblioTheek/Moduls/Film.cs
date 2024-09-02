using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMediaBiblioTheek.Moduls
{
    //interface Film (penenerapan)
    public class Film:IFilm
    {
        private string _filmTitle { get; set; }
        public Film(string filmTitle)
        {
            _filmTitle = filmTitle;
        }
        public void watch()
        {
            Console.WriteLine($"Watch from {_filmTitle}");
        }

        public void ToonDetails()
        {
            Console.WriteLine($"Show details film {_filmTitle}");
        }
    }
}
