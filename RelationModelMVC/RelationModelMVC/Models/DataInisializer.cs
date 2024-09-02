namespace RelationModelMVC.Models
{
    public class DataInisializer
    {
        public static List<Department> SeedDepartment()
        {
            List<Department> departments = new List<Department>
            {
                new Department{Id = 1, Name="HR"},
                new Department{Id = 2,Name="IT"},
                new Department{Id = 3, Name="FIinace"},
            };
            return departments;
        }
        public static List<Employ> SeedEmploy()
        {
            List<Employ> employ = new List<Employ>
            {
                new Employ {Id = 1, Name = "Rik", Position="Manager", Department = new Department{Name="HR"}},
                new Employ {Id = 2, Name = "Alain", Position="Manager", Department = new Department{Name="HrR"}},
                new Employ {Id = 3,Name = "Kenan", Position="Staff", Department = new Department{Name="IT"}},
                new Employ {Id = 4,Name = "Emo", Position="Manager", Department = new Department{Name="Hr"}},
                new Employ {Id = 5, Name = "Deny", Position="Staff", Department = new Department{Name="FInace"}},
                new Employ {Id = 6,Name = "Jonas", Position="Manager", Department = new Department{Name="Finance"}}
            };
            return employ;
        }
    }
}
