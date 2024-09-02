using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMaticProperties
{
    public class Person
    {
        public int Age { get; private set; }
        public string Name { get; set; }

        public Person(int age)
        {
            Age = age;
        }
    }
}
