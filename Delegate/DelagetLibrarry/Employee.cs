using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagetLibrarry
{
    public class Employee
    {
        //Delegate adalah container dari methodde
        public delegate bool PromoteDelegate(Employee employeeToPromote);
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public int YearExperienc { get; set; }
        public double Salary { get; set; }


        //Traditional Way
        //public static void Promot(Employee emploi) //JIka tidak ingin buat new
        //{
        //    if (emploi.YearExperienc > 3)
        //    {
        //        Console.WriteLine($"{emploi.Name} + Promoted, new salary is: " + (emploi.Salary+=emploi.Salary * 0.05));
        //    }
            
        //}
        public static void Promote (List<Employee> employeesList,Predicate<Employee> promotDelaget) // list dari main methode
        {
            foreach (Employee employee in employeesList)
            {
                if (promotDelaget (employee))
                {
                    Console.WriteLine($"{employee.Name} + Promoted, new salary is: " + (employee.Salary += employee.Salary * 0.05));
                }
            }
        }
    }
}
