using Microsoft.AspNetCore.Mvc;
using RelationModelMVC.Models;
using System.Diagnostics;

namespace RelationModelMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
