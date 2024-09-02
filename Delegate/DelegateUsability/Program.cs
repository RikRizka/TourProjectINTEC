using System;
using System.Collections.Generic;
using DelegateUsability;
using DelagetLibrarry;

namespace DelegateUsability
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee() { Id = 1, Name = "Salvatore", JobDescription = "Programmer", YearExperienc = 2, Salary = 3000.00 };
            Employee employee2 = new Employee() { Id = 2, Name = "Hugo", JobDescription = "Manager", YearExperienc = 3, Salary = 2000.00 };
            Employee employee3 = new Employee() { Id = 3, Name = "Dritan", JobDescription = "Programmer", YearExperienc = 4, Salary = 2500.00 };
            Employee employee4 = new Employee() { Id = 4, Name = "Hasan", JobDescription = "Sales", YearExperienc = 5, Salary = 3200.00 };
            Employee employee5 = new Employee() { Id = 5, Name = "Gabriela", JobDescription = "HR", YearExperienc = 4, Salary = 3100.00 };
            Employee employee6 = new Employee() { Id = 6, Name = "Olesia", JobDescription = "Sales", YearExperienc = 2, Salary = 1900.00 };
            Employee employee7 = new Employee() { Id = 7, Name = "Zakaria", JobDescription = "HR", YearExperienc = 9, Salary = 1700.00 };
            Employee employee8 = new Employee() { Id = 8, Name = "Eveline", JobDescription = "Programmer", YearExperienc = 7, Salary = 3100.00 };
            Employee employee9 = new Employee() { Id = 9, Name = "Santiago", JobDescription = "HR", YearExperienc = 6, Salary = 2800.00 };
            Employee employee10 = new Employee() { Id = 10, Name = "Reem", JobDescription = "HR", YearExperienc = 3, Salary = 3100.00 };
            Employee employee11 = new Employee() { Id = 11, Name = "Rik", JobDescription = "HR", YearExperienc = 4, Salary = 3100.00 };
            employees.Add(employee1); employees.Add(employee2); employees.Add(employee3);
            employees.Add(employee4); employees.Add(employee5); employees.Add(employee6); employees.Add(employee7);
            employees.Add(employee8); employees.Add(employee9); employees.Add(employee10); employees.Add(employee11);

            Console.WriteLine();
            Console.WriteLine("**Base on Experience**");

            Employee.Promote(employees, x => x.Salary < 3000.00);

            Console.WriteLine("**Base on JobDescription");
            Employee.Promote(employees, x => x.JobDescription == "Programer");

            //foreach (Employee employee in employees)
            //{

            //Employee.Promote(employees, PromotoBaseOnJobDescription);//Kalau static pake Klass
            //Console.WriteLine("**Base on Job");
            //}


        }
        

        //public static bool PromotoBaseOnYearExperience(Employee employee)
        //{
        //    if(employee.YearExperienc > 3)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public static bool PromotoBaseOnJobDescription(Employee employee)
        //{
        //    if (employee.JobDescription == "Programmer" && employee.Id ==3 )
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
