using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoClassCRUD
{
    public class PersonenManager
    {
        public ObservableCollection<Persoon> Personen { get; private set; } //private set bisa di lihat tapi tidak bisa di ubah

        public PersonenManager()
        {
            Personen = new ObservableCollection<Persoon>();
            SeedData();
        }
        private void SeedData()
        {
            Personen.Add(new Persoon { Naam = "Rik", Leeftijd = 25, Adres = new Adres { Straat = "Hood", Stad = "Antwerpen" } });
            Personen.Add(new Persoon { Naam = "Zak", Leeftijd = 28, Adres = new Adres { Straat = "Hood", Stad = "Antwerpen" } });
            Personen.Add(new Persoon { Naam = "Gabriela", Leeftijd = 24, Adres = new Adres { Straat = "Hood", Stad = "Antwerpen" } });
            Personen.Add(new Persoon { Naam = "Alain", Leeftijd = 63, Adres = new Adres { Straat = "Hood", Stad = "Antwerpen" } });
        }
    }

}
