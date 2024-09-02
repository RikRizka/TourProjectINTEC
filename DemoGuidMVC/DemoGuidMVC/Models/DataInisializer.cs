using DemoGuidMVC.Models;

namespace RelationModelMVC.Models
{
    public class DataInisializer
    {
        public static List<Department> SeedDepartment()
        {
            List<Department> departments = new List<Department>
            {
                new Department{Id = Guid.NewGuid(), Name="HR"},
                new Department{Id = Guid.NewGuid(),Name="IT"},
                new Department{Id = Guid.NewGuid(), Name="FIinace"},
            };
            return departments;
        }
        public static List<Employ> SeedEmploy()
        {
            List<Employ> employ = new List<Employ>
            {
                new Employ {Id = Guid.NewGuid(), Name = "Rik", Position="Manager", Department = new Department{Name="HR"}},
                new Employ {Id = Guid.NewGuid(), Name = "Alain", Position="Manager", Department = new Department{Name="HrR"}},
                new Employ {Id = Guid.NewGuid(),Name = "Kenan", Position="Staff", Department = new Department{Name="IT"}},
                new Employ {Id = Guid.NewGuid(),Name = "Emo", Position="Manager", Department = new Department{Name="Hr"}},
                new Employ {Id = Guid.NewGuid(), Name = "Deny", Position="Staff", Department = new Department{Name="FInace"}},
                new Employ {Id = Guid.NewGuid(),Name = "Jonas", Position="Manager", Department = new Department{Name="Finance"}}
            };
            return employ;
        }
    }
}
