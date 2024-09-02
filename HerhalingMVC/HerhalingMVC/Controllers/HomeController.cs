using HerhalingMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HerhalingMVC.Controllers
{
    public class HomeController : Controller
    {
        ///private readonly ILogger<HomeController> _logger;

        public HomeController()//(ILogger<HomeController> logger) //Dependence injection
        {
           // _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
