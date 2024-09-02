using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinkQ
{
    public class StudentProp
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int Age { get; set; }

        public StudentProp(int studentId, string studentName, int age)
        {        
            StudentId = studentId;
            StudentName = studentName;
            Age = age;  
        }
        public override string ToString()
        {
            return $" {StudentId} {StudentName} {Age}";
        }
    }
}
