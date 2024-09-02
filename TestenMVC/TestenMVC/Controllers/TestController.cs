using Microsoft.AspNetCore.Mvc;

namespace TestenMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hello = "Hello";
            ViewData["Hello"] = "World";
            return View();
        }
        public IActionResult Loop()
        {
            int[] num = new int[20];
            ViewBag.Num = num;
            return View();
        }
    }
}
