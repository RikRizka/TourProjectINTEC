using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructRevisted
{
    public struct Student
    {
        public string FirstName;
        public string LastName;
        public string Adress;
        public int Age;

        // hanya tulis ctor dan tab(untuk mempercepat).
        public Student(string firstName, string lastName, string adress, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            Age = age;

            //Klau huruf Besar  di bagian atas Method seperti string FirstName
            //this.FirstName = FirstName
            //this.FristName itu berasal dari public string FirstName
            
        }
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public override string ToString() //override to show another
        {
            return GetFullName() + " " + Adress + " " + Age;
        }


    }


}
