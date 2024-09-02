using System;
using ConstructorChainDemo.Models;

namespace ConstructorChainDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Student student1 = new Student();           
            Student student2 = new Student("John");           
            Student student3 = new Student("John","Doe");            
            Student student4 = new Student("John","Doe",25);
            Student student5 = new Student("Rik","Rizka",23);
            Console.WriteLine(Student.Count); // static belong to cless

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.WriteLine(student4);
            Console.WriteLine(student5);    

            Console.ReadLine();
        }
    }
}
