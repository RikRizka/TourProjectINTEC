using Microsoft.AspNetCore.Mvc;
using RelationModelsMVC.Models;

namespace RelationModelsMVC.Controllers
{
    public class DepartmentController : Controller
    {
        static List<Department> departmentFirstTime = DataInitializer.SeedDepartment();
        public IActionResult Index()
        {
            var departments = departmentFirstTime;
            return View(departments);

        }
        public IActionResult Details(int id)
        {
            var department = DataInitializer.SeedDepartment().Find(d => d.Id == id);
            return View(department);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = departmentFirstTime.Find(d => d.Id == id);
            return View(department);

        }
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            var existingItem = departmentFirstTime.Find(i=>i.Id == department.Id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = department.Name;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var found = departmentFirstTime.Find(i => i.Id == id);
            if (found == null) 
            {
                return NotFound();
            }
            departmentFirstTime.Remove(found);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            var NextId = departmentFirstTime.Capacity;
            ViewBag.Id = NextId;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
          var NextId = departmentFirstTime.Capacity;
            department.Id = NextId;
            departmentFirstTime.Add(department);
            return RedirectToAction("Index");
        }
    }

}
