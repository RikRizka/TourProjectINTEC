using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaleMediaBibliotheek
{
    public class MusicAlbum:IMusicAlbum
    {
        public string Judul { get; set; }
        public MusicAlbum(string judul):base()
        {
            Judul = judul;
        }
    }
}
