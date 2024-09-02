using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindDelegate
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        //public string ToString(PersonFormat format) //Tanpa Fun di gunakan untuk public delegate
        //{
        //    if (format != null)
        //    {
        //        return format(this); // prinsip dari toString
        //    }
        //    return this.ToString();
        //}
        public string ToString(Func<Person, string> format)
        {
            if (format != null)
            {
                return format(this); // prinsip dari toString
            }
            return this.ToString();
        }


    }
}
    