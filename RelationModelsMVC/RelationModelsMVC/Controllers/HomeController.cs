using Microsoft.AspNetCore.Mvc;
using RelationModelsMVC.Models;
using System.Diagnostics;

namespace RelationModelsMVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index(int id, string str)
        {
            ViewBag.Id = id;
            ViewBag.str = str;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
