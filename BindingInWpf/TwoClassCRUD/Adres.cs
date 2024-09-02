using System.ComponentModel;
using System.Xml.Linq;

namespace TwoClassCRUD
{
    public class Adres : INotifyPropertyChanged
    {
        private string _straat;
        private string _stad;

       public string Straat
        {
            get
            {
                return _straat;
            }
            set
            {
                _straat = value;
               // OnPropertyChanged(nameof(Straat));
            }
        }
        public string Stad
        {
            get
            {
                return _stad;
            }
            set
            {
                _stad = value;
                //OnPropertyChanged(nameof(Stad));

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        //protected void OnPropertyChanged(string property)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        //}
    }
}