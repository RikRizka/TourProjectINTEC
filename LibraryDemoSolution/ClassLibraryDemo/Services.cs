using ClassLibraryDemo.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibraryDemo
{
    public class Services
    {
        public Person DoSomthing()
        {
            //di realita data base
            Person person = new Person();
            person.FirstName = "Rick";
            person.LastName = "Usmn";
            person.DateOfBirth = new DateTime(1980,1 ,1);
            return person;
                       
        }
        public Person CalculateAge (Person person)
        {
            person.Age = DateTime.Now.Year - person.DateOfBirth.Year;
            return person;
        }
        public Person GetAgeMinTwee (Person person) 
        {
            person.Age = DateTime.Now.Year - person.DateOfBirth.Year -2 ;
            return person;
        }
    }
}
