using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinkQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StudentProp> list = new List<StudentProp>()
            {
            new StudentProp(1,"Rick",12),
            new StudentProp(2,"Alain",10)

            };
            //Query Sintac
            //var hasil = from s in list
            //            where s.StudentId == 2
            //            select s;
            //foreach (var s in hasil)
            //{
            //    Console.WriteLine(s.StudentName);
            //}

            //Lamda Sin
            var hasil = list.Where(s => s.StudentId == 2);
            foreach (var s in hasil)
            {
                Console.WriteLine(s.StudentName);
            }
        }
           

    }
}
