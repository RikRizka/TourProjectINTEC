using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "rik";
            student.Age = 20;
            student.Address = "123 main st";
            student.Email = "Rick@gmail.com";

            //Console.WriteLine(student.ToString());

            Student student2 = new Student();

            student.Name = "Dritan";
            student.Age = 21;
            student.Address = "123 main st";
            student.Email = "Rick@gmail.com";

            // Console.WriteLine(s2);
            Student student3 = new Student() { Name = "Hugo", Age = 27 };

            Student[] students = new Student[3];
            students[0] = student;
            students[1] = student2;
            students[2] = student3;

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }


        }
    }
}
