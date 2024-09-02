using CalculatorMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection;

namespace CalculatorMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.FutureValue = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = model.Calculate().ToString("C3");
            }
            else
            {
                ViewBag.FutureValue = 0;
            }
            return View(model);
        }

      
    }
}
