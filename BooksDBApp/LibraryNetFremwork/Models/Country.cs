using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBooks.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public override string ToString()
        {
            return $"{Id} {Naam}";
        }
    }
}
