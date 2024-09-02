using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person(new DateTime(1993,10,18));
            // person.SetBirthdate(new DateTime(1993,02,25)); //date time hanya satu kali
            // jika ingin yang akan datant  harus (new DateTime
            //Person.BirthDate = new Person();

            Person person = new Person();
            person.BirthDate = new DateTime(1993,10,18);
            
            Console.WriteLine(person.Brithday);
            Console.WriteLine(person.Age); 
        }
    }
}
