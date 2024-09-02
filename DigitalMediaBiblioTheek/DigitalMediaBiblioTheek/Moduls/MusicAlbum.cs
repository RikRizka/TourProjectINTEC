using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMediaBiblioTheek.Moduls
{
    public class MusicAlbum:IMusicAlbum
    {
        //Penerapan kelas MusicAlbum
        private string _albumNaam { get; set; }
        public MusicAlbum(string albumNaam)
        {
            _albumNaam = albumNaam; 
        }

        public void Play()
        {
            Console.WriteLine($"Play from {_albumNaam}");
        }

        public void ToonDetailds()
        {
            Console.WriteLine($"Details from albums {_albumNaam}");
        }
    }
}
