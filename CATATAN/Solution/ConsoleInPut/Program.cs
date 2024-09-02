using System;
using System.Runtime.Remoting.Services;

namespace ConsoleInPut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region

            //Console.WriteLine($"studentName {studentName} studentAge {studentAge}");
            //Console.ReadLine();
            #endregion

            string studentName;
            int studentBornYear;
            int studentAge; 

            Console.Write("Enter student name : ");
            studentName = Console.ReadLine();

            Console.Write("Student born year : ");
            studentBornYear = Int32.Parse(Console.ReadLine());
            studentAge = 2023 - studentBornYear;

            Console.WriteLine($"you entered {studentName} and {studentBornYear}");
            Console.WriteLine($"{studentName} You are {studentAge} years old");
            Console.ReadLine();

        }
    }
}
