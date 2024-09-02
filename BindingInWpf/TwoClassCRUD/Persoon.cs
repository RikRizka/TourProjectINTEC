using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoClassCRUD
{
    public class Persoon : INotifyPropertyChanged
    {
        private string _name;
        private int _leeftijd;

        public Adres Adres { get; set; }
        public string Naam
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
            
        }
        public int Leeftijd
        {
            get
            {
                return _leeftijd;
            }
            set
            {
                _leeftijd = value;
                OnPropertyChanged("Leeftijd");
            }
        }

     
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
