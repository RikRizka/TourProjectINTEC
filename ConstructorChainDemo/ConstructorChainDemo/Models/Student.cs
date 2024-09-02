using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainDemo.Models
{
    internal class Student
    {
        public static int Count = 0; // static belong to the calls
        public string FirstName;
        public string LastName;
        public int Age;

        public Student()
        {
            Count++;
        }
        public Student(string firstrName):this()
        {
            FirstName = firstrName;

        }
        public Student(string firstrName, string lastName):this(firstrName)
        {
            LastName = lastName;
            //di hapus karena sudah pergi ke this di atas {ini prinsip Dry" do not reapet your self"}
            // LastName = lastName;
        }
        public Student (string firstrName, string lastName,int age):this(firstrName,lastName) 
        {
            //di hapus karena sudah di isi di atas this
            //FirstName = firstrName;
            //LastName = lastName;
            Age = age;          
        }
        public override string ToString()
        {
            return $"First Name: {FirstName} Last name: {LastName} Age : {Age}";
        }
    }
}
