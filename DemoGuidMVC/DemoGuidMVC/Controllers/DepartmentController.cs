using DemoGuidMVC.Models;
using Microsoft.AspNetCore.Mvc;
using RelationModelMVC.Models;

namespace RelationModelMVC.Controllers
{
    public class DepartmentController : Controller
    {
        static List<Department> firstDepartment = DataInisializer.SeedDepartment();
        public IActionResult Index()
        {
            var departments = firstDepartment;
            return View(departments);
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var departments = firstDepartment.Find(f => f.Id == id);
            return View(departments);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var department = firstDepartment.Find(d => d.Id == id);
            return View(department);

        }
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            var existingItem = firstDepartment.Find(i => i.Id == department.Id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = department.Name;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var found = firstDepartment.Find(i => i.Id == id);
            if (found == null)
            {
                return NotFound();
            }
            firstDepartment.Remove(found);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create(Guid id)
        {
            var NextId = firstDepartment.Capacity;
            ViewBag.Id = NextId;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
           
            firstDepartment.Add(department);
            return RedirectToAction("Index");
        }


    }
}
