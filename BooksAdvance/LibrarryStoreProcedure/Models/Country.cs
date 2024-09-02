using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarryStoreProcedure.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Prijs { get; set; }
        public string Describe { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Title} {Author} {Prijs} {CountryId} {Desription}";
        }
    }
}
