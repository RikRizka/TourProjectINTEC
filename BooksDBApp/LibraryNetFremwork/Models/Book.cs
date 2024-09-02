using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Prijs { get; set; }
        public string Describe { get; set; }
        public int CountryId { get; set; }

        public override string ToString()
        {
            return $"{Title} {Author} {Prijs} {CountryId}";
        }
    }
    
    
}
