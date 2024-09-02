using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg
{
    public class PersonColection:IEnumerable<Person> // bnyak
    {
        private List<Person> personen = new List<Person>();

        public void Add (Person person)
        {
            personen.Add (person);
        }

        public IEnumerator<Person> GetEnumerator() //Generik karena <Person> "Interface"
        {
          return personen.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() //NonGenerik
        {
            return GetEnumerator();
        }
    }
}
