using Microsoft.AspNetCore.Mvc;
using RelationModelsMVC.Models;

namespace RelationModelsMVC.Controllers
{
    public class EmployController : Controller
    {
        static List<Employ> employFirstTime = DataInitializer.SeedEmploy();
        public IActionResult Index()
        {

            var employes = employFirstTime;
            return View(employes);

        }
        public IActionResult Details(int id)
        {
            var employes = DataInitializer.SeedEmploy().Find(f => f.Id == id);
            return View(employes);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employ = DataInitializer.SeedEmploy().Find(f => f.Id == id);
            return View(employ);
        }
        [HttpPost]
        public IActionResult Edit(Department employ)
        {
            var existingItem = employFirstTime.Find(i => i.Id == employ.Id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = employ.Name;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var found = employFirstTime.Find(i => i.Id == id);
            if (found == null)
            {
                return NotFound();
            }
            employFirstTime.Remove(found);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            //var newEmployeeId = employFirstTime.LastOrDefault().Id + 1;
            //ViewBag.EmployeeId = newEmployeeId;
            //return View();
            var NextId = employFirstTime.LastOrDefault().Id + 1; ;
            ViewBag.Id = NextId;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employ employ)
        {
            //employFirstTime.Add(employ);
            //return RedirectToAction("Index");
            //var NextId = employFirstTime.Count +1;
            //employ.Id = NextId;
            employFirstTime.Add(employ);
            return RedirectToAction("Index");
        }
    }
    
}
