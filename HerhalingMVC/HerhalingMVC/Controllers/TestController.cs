using Microsoft.AspNetCore.Mvc;

namespace HerhalingMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacie() 
        {
            return View();
        }
    }
}
