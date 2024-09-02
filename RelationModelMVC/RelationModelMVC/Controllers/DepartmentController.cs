using Microsoft.AspNetCore.Mvc;
using RelationModelMVC.Models;

namespace RelationModelMVC.Controllers
{
    public class DepartmentController : Controller
    {
        List<Department> firstDepartment = DataInisializer.SeedDepartment();
        public IActionResult Index()
        {
            var departments = firstDepartment;
            return View(departments);
        }
    }
}
