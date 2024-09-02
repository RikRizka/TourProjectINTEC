using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructRevisted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); //wat gebeuurt new? place for Student
            
            s1.FirstName = "Rik";
            s1.LastName = "Rizka";
            s1.Adress = "Carel st";
            s1.Age = 20;

            PrintStudent(s1);
            //Console.WriteLine(s1.Age);
            //Console.WriteLine(s1.GetFullName());
            //Console.WriteLine(s1.ToString());

            Student s2 = new Student();
            s2.FirstName = "Alin";
            s2.LastName = "Charlie";
            s2.Adress = "Bxl";
            s2.Age = 60;
            //Console.WriteLine(s2.GetFullName());
            //Console.WriteLine(s2.ToString());

            Console.WriteLine("__________________________");
            Student s3 = new Student("Salvatore", "Vella", "Brussel", 20);
            //Console.WriteLine(s3);
            //Console.WriteLine(s3.GetFullName());
            //Console.WriteLine(s3.ToString());




        }
        static void PrintStudent(Student s)
        {
            s.Age = 30;

        }
    }
}
